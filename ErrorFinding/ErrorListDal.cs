using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Reflection.Metadata;
using System.Text;

namespace ErrorFinding
{
    public class ErrorListDal
    {
            public List<ErrorList> GetErrorListApi()
            {
                string url = "https://developmentapi.fonhub.xyzteknoloji.com/api/errorrecord/all";

                using (HttpClient webClient = new HttpClient())
                {
                    string json = webClient.GetStringAsync(url).Result;
                    List<ErrorList> errorListApi = JsonConvert.DeserializeObject<List<ErrorList>>(json);

                    return errorListApi;
                }
            }

            public List<ErrorList> GetErrorListUI()
            {
                List<ErrorList> errorListUI = new List<ErrorList>();

                string url = "https://raw.githubusercontent.com/xyztek/CrowdFundingUI/master/src/shared/language/english.json";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", "token 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");
                    client.DefaultRequestHeaders.Add("Accept", "application / vnd.github.v3.raw");

                    var jsonData = client.GetStringAsync(url).Result;
                    JObject jsonObject = JObject.Parse(jsonData);

                    var result = jsonObject.SelectToken("errorCodes");

                    foreach (JProperty item in result.Children())
                    {
                        ErrorList error = new ErrorList();

                        error.extendedErrorCode = item.Name.ToString();
                        error.defaultDescription = item.Value.ToString();

                        errorListUI.Add(error);
                    }
                }
                return errorListUI;
            }

            public List<ErrorList> GetErrorListManagement(string path)
            {
                List<ErrorList> errorListManagement= new List<ErrorList>();
            string allErrorText="";
            using (HttpClient wc = new HttpClient())
            {
                wc.DefaultRequestHeaders.Add("Authorization", "token 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");
                wc.DefaultRequestHeaders.Add("Accept", "application / vnd.github.v3.raw");
                try
                {
                    allErrorText = wc.GetStringAsync(path).Result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            int startPoint = allErrorText.IndexOf("{");
                int finishPoint = allErrorText.LastIndexOf(",");
                string clearErrorText = allErrorText.Substring(startPoint + 1, finishPoint - startPoint - 1);
                int clearCharIndex= clearErrorText.LastIndexOf('\"');
                clearErrorText= clearErrorText.Remove(clearCharIndex);
                string[] stringSeperator = new string[] { "\",", "\'," };
                string[] errorLine = clearErrorText.Split(stringSeperator, StringSplitOptions.None);

                foreach (string errorText in errorLine)
                {
                    string errorTextTemp = errorText;
                    int codeFinishPoint = errorTextTemp.IndexOf(":");
                    string errorCode = errorTextTemp.Substring(0, codeFinishPoint);
                    errorCode = errorCode.Replace("\n", "").Replace(" ", "");

                    string errorMessage = errorTextTemp.Substring(codeFinishPoint + 1, errorTextTemp.Length - codeFinishPoint - 1);
                    string errorMessageCheck = errorMessage.Replace("\n", "").Replace(" ", "");
                    int messageStartPoint;
                    int messageFinishPoint;

                    if (errorMessageCheck[0] == '\"')
                    {
                        errorMessage += "\"";
                        messageStartPoint = errorMessage.IndexOf("\"");
                        messageFinishPoint = errorMessage.LastIndexOf("\"");
                    }
                    else
                    {
                        errorMessage += "\'";
                        messageStartPoint = errorMessage.IndexOf("\'");
                        messageFinishPoint = errorMessage.LastIndexOf("\'");
                    }
                    errorMessage = errorMessage.Substring(messageStartPoint + 1, messageFinishPoint - messageStartPoint-1 );
                    ErrorList newError = new ErrorList();
                    newError.extendedErrorCode = errorCode;
                    newError.defaultDescription = errorMessage;
                    errorListManagement.Add(newError);
                    //Console.WriteLine(newError.extendedErrorCode + ":" + newError.defaultDescription);
                    }
                    return errorListManagement ?? new List<ErrorList>();
            }
    }
}
