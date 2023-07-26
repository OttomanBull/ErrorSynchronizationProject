using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Google.Apis.Requests.RequestError;

namespace ErrorFinding
{
    public class ErrorListDalJson
    {
        public List<JToken> GetErrorListApi()
        {
            string url = "https://developmentapi.fonhub.xyzteknoloji.com/api/errorrecord/all";

            using (HttpClient hc = new HttpClient())
            {
                string json = hc.GetStringAsync(url).Result;
                List<JToken> errorListApi = JsonConvert.DeserializeObject<List<JToken>>(json);

                return errorListApi;
            }
        }

        public JToken GetErrorListUI()
        {
            string url = "https://raw.githubusercontent.com/xyztek/CrowdFundingUI/master/src/shared/language/english.json";
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Authorization: token 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");
                client.Headers.Add("Accept: application / vnd.github.v3.raw");

                var jsonData = client.DownloadString(url);
                JToken errorListUi = JToken.Parse(jsonData);
                JToken result = errorListUi.SelectToken("errorCodes");
                return result;
            }

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
