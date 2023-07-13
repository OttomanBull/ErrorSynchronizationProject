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

            StreamReader StreamReader = new StreamReader(@"C:\Users\Work and Study\Desktop\english-UI.json");
            var jsonData = StreamReader.ReadToEnd();
            JObject jsonObject = JObject.Parse(jsonData);

            var result = jsonObject.SelectToken("errorCodes");



            foreach (JProperty item in result.Children())
            {
                ErrorList error = new ErrorList();

                error.extendedErrorCode = item.Name.ToString();
                error.defaultDescription = item.Value.ToString();

                errorListUI.Add(error);

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

        public List<ErrorList> ErrorCodeComparison(List<ErrorList> list1, List<ErrorList> list2)
        {
            List<ErrorList> errorListComparison = new List<ErrorList>();
            errorListComparison = list1.Except(list2).ToList();
            return errorListComparison;
        }

       

        public List<ErrorList> ErrorCodeComparison2(List<ErrorList> list1, List<ErrorList> list2)
        {
            List<string> extendedErrorCodes1 = list1.Select(x => x.extendedErrorCode).ToList();
            List<string> extendedErrorCodes2 = list2.Select(x => x.extendedErrorCode).ToList();

            List<string> uniqueExtendedErrorCodes = extendedErrorCodes1.Except(extendedErrorCodes2).ToList();

            List<ErrorList> uniqueErrors = list1.Where(x => uniqueExtendedErrorCodes.Contains(x.extendedErrorCode)).ToList();

            return uniqueErrors;
        }


    }
}
