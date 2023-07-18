using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace ErrorFinding
{
    public class ErrorListDal
    {
        public List<ErrorList> GetErrorListApi()
        {
            List<ErrorList> errorListApi = null;

            string url = "https://developmentapi.fonhub.xyzteknoloji.com/api/errorrecord/all";
            using (HttpClient webClient = new HttpClient())
            {
                try
                {
                    //string json = webClient.DownloadString(url);
                    string json= webClient.GetStringAsync(url).Result;   
                    errorListApi = JsonConvert.DeserializeObject<List<ErrorList>>(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata oluştu: " + ex.Message);
                }
            }
            return errorListApi ?? new List<ErrorList>();
        }
        public void GetErrorListUI()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            Tuple<int, int> tuple = new Tuple<int, int>(1, 2);

            StreamReader StreamReader = new StreamReader(@"C:\Users\Work and Study\Desktop\english-UI.json");
            var jsonData = StreamReader.ReadToEnd();

            JObject jsonObject = JObject.Parse(jsonData);

            var result = jsonObject.SelectToken("errorCodes");

            foreach (JProperty item in result.Children())
            {
                var value = item.Value.ToString();
                keyValuePairs.Add(item.Name, value);
            }

            Console.ReadLine();

        }

        public List<ErrorList> GetErrorListManagement(string path)
        {
            List<ErrorList> errorListManagement= new List<ErrorList>();    
            ReadUrl read =new ReadUrl();
            string allErrorText = read.readUrl(path);
            Console.Write(allErrorText);

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
