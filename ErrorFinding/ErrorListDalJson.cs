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

        public string GetTextFromGithub(string url)
        {
            string errorText;
            using (HttpClient wc = new HttpClient())
            {
                wc.DefaultRequestHeaders.Add("Authorization", "token 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");
                wc.DefaultRequestHeaders.Add("Accept", "application / vnd.github.v3.raw");
                errorText = wc.GetStringAsync(url).Result;
            }
            return errorText;
        }

        public string JsTextToJsonText(string path)
        {
            string jsErrorText = GetTextFromGithub(path);
            int startPoint = jsErrorText.IndexOf("{");
            int finishPoint = jsErrorText.LastIndexOf("\",") - 1;

            jsErrorText = jsErrorText.Substring(startPoint + 1, finishPoint - startPoint).Replace("\'", "\"");
            string[] stringSeperator = new string[] { "\",", "\'," };
            string[] errorLine = jsErrorText.Split(stringSeperator, StringSplitOptions.None);
            string jsonText = "{\"errorCodes\": {\n";

            foreach (string line in errorLine)
            {
                string demo = line.Trim();
                demo = demo.Substring(0, demo.IndexOf("\"")) + "\"" + demo.Substring(demo.IndexOf("\"") + 1, demo.Length - demo.IndexOf("\"") - 1).Replace("\"", "\'");
                demo = demo.Insert(0, "\"").Insert(demo.IndexOf(":") + 1, "\"").Insert(demo.Length + 2, "\",");
                jsonText += demo + "\n";
            }
            jsonText += "} }";

            return jsonText;
        }

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

        public JToken GetErrorListUI(string url)
        {
             var jsonData = GetTextFromGithub(url);
             JToken errorListUi = JToken.Parse(jsonData);

             return errorListUi;
        }

        public JToken GetErrorListManagement(string path)
        {
            string finaleErrorText = JsTextToJsonText(path);
            JObject managamentList = JObject.Parse(finaleErrorText);

            return managamentList;
        }


    }
}
