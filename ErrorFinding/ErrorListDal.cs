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
            List<ErrorList> errorListUI2 = new List<ErrorList>();

            string url = "https://raw.githubusercontent.com/xyztek/CrowdFundingUI/master/src/shared/language/english.json?token=GHSAT0AAAAAACFBXO3EANKMDUZ3GVB6I75OZFP5WFQ";
            using (WebClient client = new WebClient())
            {
                var jsonData = client.DownloadString(url);
                JObject jsonObject = JObject.Parse(jsonData);

                var result = jsonObject.SelectToken("errorCodes");

                foreach (JProperty item in result.Children())
                {
                    ErrorList error = new ErrorList();

                    error.extendedErrorCode = item.Name.ToString();
                    error.defaultDescription = item.Value.ToString();

                    errorListUI2.Add(error);
                }
            }

            return errorListUI2;
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

        public List<ErrorList> ErrorCodeComparison(List<ErrorList> list1, List<ErrorList> list2)
        {
            List<string> extendedErrorCodes1 = list1.Select(x => x.extendedErrorCode).ToList();
            List<string> extendedErrorCodes2 = list2.Select(x => x.extendedErrorCode).ToList();

            List<string> uniqueExtendedErrorCodes = extendedErrorCodes1.Except(extendedErrorCodes2).ToList();

            List<ErrorList> uniqueErrors = list1.Where(x => uniqueExtendedErrorCodes.Contains(x.extendedErrorCode)).ToList();

            return uniqueErrors;
        }


    }
}
