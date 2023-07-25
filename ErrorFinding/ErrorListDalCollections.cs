using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ErrorFinding
{
    public class ErrorListDalCollections
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

                    error.extendedErrorCode = item.Name.ToString();
                    error.defaultDescription = item.Value.ToString();

                    errorListUI.Add(error);
                }
            }
            return errorListUI;
        }

        public List<ErrorList> GetErrorListManagement(string path)
        {
            string errorText;
            List<ErrorList> errorListManagement = new List<ErrorList>();
            using (HttpClient wc = new HttpClient())
            {
                wc.DefaultRequestHeaders.Add("Authorization", "token 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");
                wc.DefaultRequestHeaders.Add("Accept", "application / vnd.github.v3.raw");
                errorText = wc.GetStringAsync(path).Result;

                int startPoint = errorText.IndexOf("{");
                int finishPoint = errorText.LastIndexOf("\",") - 1;
                errorText = errorText.Substring(startPoint + 1, finishPoint - startPoint).Replace("\'", "\"");

                string[] stringSeperator = new string[] { "\",", "\'," };
                string[] errorLine = errorText.Split(stringSeperator, StringSplitOptions.None);
                string finaleErrorText = "{\"errorCodes\": {\n";

                foreach (string line in errorLine)
                {
                    string demo = line.Trim();
                    demo = demo.Substring(0, demo.IndexOf("\"")) + "\"" + demo.Substring(demo.IndexOf("\"") + 1, demo.Length - demo.IndexOf("\"") - 1).Replace("\"", "\'");
                    demo = demo.Insert(0, "\"").Insert(demo.IndexOf(":") + 1, "\"").Insert(demo.Length + 2, "\",");
                    finaleErrorText += demo + "\n";
                }
                finaleErrorText += "} }";

                JObject jsonObject = JObject.Parse(finaleErrorText);
                var result = jsonObject.SelectToken("errorCodes");

                foreach (JProperty item in result.Children())
                {
                    ErrorList error = new ErrorList();
                    error.extendedErrorCode = item.Name.ToString();
                    error.defaultDescription = item.Value.ToString();
                    errorListManagement.Add(error);
                }
            }
            return errorListManagement.ToList();
        }
    }
}
