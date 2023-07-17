using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ErrorFinding
{
    public class ErrorListDal
    {
      
        public List<ErrorList> GetErrorListApi()
        {
            string url = "https://developmentapi.fonhub.xyzteknoloji.com/api/errorrecord/all";

            using (WebClient webClient = new WebClient())
            {
                string json = webClient.DownloadString(url);
                List<ErrorList> errorListApi = JsonConvert.DeserializeObject<List<ErrorList>>(json);

                return errorListApi;
            }
        }

        public List<ErrorList> GetErrorListUI()
        {
            List<ErrorList> errorListUI = new List<ErrorList>();

            string url = "https://raw.githubusercontent.com/xyztek/CrowdFundingUI/master/src/shared/language/english.json";
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Authorization: token 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");
                client.Headers.Add("Accept: application / vnd.github.v3.raw");
                
                var jsonData = client.DownloadString(url);
                JObject jsonObject = JObject.Parse(jsonData);

                var result = jsonObject.SelectToken("errorCodes");

                foreach (JProperty item in result.Children())
                {
                    ErrorList error = new ErrorList();

                    error.ExtendedErrorCode = item.Name.ToString();
                    error.DefaultDescription = item.Value.ToString();

                    errorListUI.Add(error);
                }
            }
            return errorListUI;
        }

        public void GetErrorListManagement(string path)
        {
            string allErrorText = File.ReadAllText(path);

            int startPoint = allErrorText.IndexOf("{");
            int finishPoint = allErrorText.LastIndexOf(",");

            string clearErrorText = allErrorText.Substring(startPoint + 1, finishPoint - startPoint - 1);
            string[] errorLine = clearErrorText.Split("\",");

            foreach (string errorText in errorLine)
            {
                string errorTextTemp = errorText;
                errorTextTemp += '\"';

                int codeFinishPoint = errorTextTemp.IndexOf(":");
                string removeChar = " ";
                string errorCode = errorTextTemp.Substring(0, codeFinishPoint - 1).Replace(removeChar, string.Empty);

                int messageStartPoint = errorTextTemp.IndexOf("\"");
                int messageFinishPoint = errorTextTemp.LastIndexOf("\"");

                string errorMessage = errorTextTemp.Substring(messageStartPoint + 1, messageFinishPoint - messageStartPoint - 1);
                Console.WriteLine(errorCode + ":  " + errorMessage);
            }
        }
    }
}
