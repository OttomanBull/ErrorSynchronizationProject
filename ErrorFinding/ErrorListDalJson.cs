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
        public JToken GetErrorListApiJson()
        {
            string url = "https://developmentapi.fonhub.xyzteknoloji.com/api/errorrecord/all";

            using (WebClient webClient = new WebClient())
            {
                var jsonData = webClient.DownloadString(url);

                JToken jsonToken = JToken.Parse(jsonData);

                JToken test = null;

                foreach (var item in jsonToken)
                {

                    JToken extendedErrorCodeData = item["extendedErrorCode"];
                    test = extendedErrorCodeData;
                  
                }
                return test;
         
            }
        }

        public JToken GetErrorListUIJson()
        {
            string url = "https://raw.githubusercontent.com/xyztek/CrowdFundingUI/master/src/shared/language/english.json";
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Authorization: token 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");
                webClient.Headers.Add("Accept: application / vnd.github.v3.raw");


                var jsonData = webClient.DownloadString(url);
                JToken jsonToken = JToken.Parse(jsonData);
                JToken jsonTokenErrorCodes = jsonToken.SelectToken("errorCodes");

                foreach (var property in jsonTokenErrorCodes.Children<JProperty>())
                {
                    JToken errorCode = (JToken)property.Name;
                    
                    jsonTokenErrorCodes = errorCode;
                    
                }
                
                return jsonTokenErrorCodes;
            }

        }


    }
}
