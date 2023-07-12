using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;

namespace ErrorFinding
{
    public class ErrorListDal
    {
        public List<KeyValuePair<string, string>> GetErrorListApi()
        {
            //verileri nereden alıcağımı programa göstermek için bir url tanımladım
            string url = "https://developmentapi.fonhub.xyzteknoloji.com/api/errorrecord/all";
            //WebClient kullnarak json dosyasındaki verileri convert edip indiriyoruz
            using (WebClient webClient = new WebClient())
            {
                
                    string json = webClient.DownloadString(url);
                //indirdiğimiz verilerin ErrorList adlı bir listeye convert edilerek gitmesini istediğimizi belirttik

                List<KeyValuePair<string, string>> errorListApi = JsonConvert.DeserializeObject<List<KeyValuePair<string, string>>>(json);

                    return errorListApi;

            
            }
        }
        public List<KeyValuePair<string, string>> GetErrorListUI()
        {
            List<KeyValuePair<string, string>> errorListUI = new List<KeyValuePair<string, string>>();
            

            StreamReader StreamReader = new StreamReader(@"C:\Users\Work and Study\Desktop\english-UI.json");
            var jsonData = StreamReader.ReadToEnd();
          

            JObject jsonObject = JObject.Parse(jsonData);

            var result = jsonObject.SelectToken("errorCodes");

            foreach (JProperty item in result.Children())
            {
                var value = item.Value.ToString();
                var name = item.Name.ToString();

                errorListUI.Add(new KeyValuePair<string, string>(name, value));                      
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

        public void ErrorCodeDiffrent(IErrorList list1, IErrorList list2,IErrorList list3)
        {
           
        }
       


    } 

}
