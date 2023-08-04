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
        public string GetErrorListFromDocument(string document)
        {
            string jsonContent = File.ReadAllText(document);
            return jsonContent;
        }

        public string JsTextToJsonText(string path)
        {
            string jsErrorText = GetErrorListFromDocument(path);
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
       
        public JToken GetErrorListUI(string document)
        {
             var jsonData = GetErrorListFromDocument(document);
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
