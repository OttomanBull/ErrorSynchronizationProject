using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;

namespace ErrorFinding
{
    public class ErrorListDal
    {
        public void GetErrorListApi()
        {
            //verileri nereden alıcağımı programa göstermek için bir url tanımladım
            string url = "https://developmentapi.fonhub.xyzteknoloji.com/api/errorrecord/all";
            //WebClient kullnarak json dosyasındaki verileri convert edip indiriyoruz
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    string json = webClient.DownloadString(url);
                    //indirdiğimiz verilerin ErrorList adlı bir listeye convert edilerek gitmesini istediğimizi belirttik
                    ErrorListApi[] errorListApi = JsonConvert.DeserializeObject<ErrorListApi[]>(json);

                    // JSON verileri C# nesnesine dönüştürüldü, artık errorList dizisi üzerinden kullanabiliriz

                    // Verilerin hepsini konsola yazdırıyoruz
                    foreach (ErrorListApi error in errorListApi)
                    {
                        Console.WriteLine("Extended Error Code: " + error.extendedErrorCode);
                        Console.WriteLine("Default Description: " + error.defaultDescription);

                        Console.WriteLine();
                    }

                    //Hata durumunda gelicek uyarı mesajı
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata oluştu: " + ex.Message);
                }
            }
        }
        public void GetErrorListUI()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            Tuple<int, int> tuple = new Tuple<int, int>(1, 2);

            StreamReader StreamReader = new StreamReader(@"C:\Users\Work and Study\Desktop\english-UI.json");
            var jsonData = StreamReader.ReadToEnd();
            //var errorListUI = JsonConvert.DeserializeObject(jsonData);

            //var stringJson = errorListUI.ToString(); 

            JObject jsonObject = JObject.Parse(jsonData);

            var result = jsonObject.SelectToken("errorCodes");

            foreach (JProperty item in result.Children())
            {
                var value = item.Value.ToString();

                keyValuePairs.Add(item.Name, value);

                Console.WriteLine(item.Name);
                Console.WriteLine(item.Value);
                Console.WriteLine("");
            }

            Console.ReadLine();

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
