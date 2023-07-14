using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace ErrorFinding
{
    public class ErrorListDal
    {
        public void GetErrorListApi(List<ErrorListApi> errorListApiList)
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
                        //Console.WriteLine("Extended Error Code: " + error.extendedErrorCode);
                        //Console.WriteLine("Default Description: " + error.defaultDescription);

                        //Console.WriteLine();
                        errorListApiList.Add(error);
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

            }

            Console.ReadLine();

        }

        public void GetErrorListManagement(string path, List<ErrorListApi> errorListManagements)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("Authorization: token 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");
                wc.Headers.Add("Accept: application / vnd.github.v3.raw");
                try
                {
                    wc.DownloadFile("https://raw.githubusercontent.com/xyztek/CrowdFundingManagement/master/src/lang/errorCodes/tr_TR.js", @"C:/Users/Elif Aslan/Desktop/test.txt");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
                string allErrorText = File.ReadAllText(@"C:/Users/Elif Aslan/Desktop/test.txt",Encoding.UTF8);

                int startPoint = allErrorText.IndexOf("{");
                int finishPoint = allErrorText.LastIndexOf(",");

                string clearErrorText = allErrorText.Substring(startPoint + 1, finishPoint - startPoint - 1);
                int clearCharIndex= clearErrorText.LastIndexOf('\"');
                clearErrorText= clearErrorText.Remove(clearCharIndex);
                //Console.WriteLine(clearErrorText);
                string[] stringSeperator = new string[] { "\",", "\'," };
                string[] errorLine = clearErrorText.Split(stringSeperator, StringSplitOptions.None);

                foreach (string errorText in errorLine)
                {
                    string errorTextTemp = errorText;
                    int codeFinishPoint = errorTextTemp.IndexOf(":");
                    string errorCode = errorTextTemp.Substring(0, codeFinishPoint);
                    errorCode = errorCode.Replace("\n", "").Replace(" ", "");

                    string errorMessage = errorTextTemp.Substring(codeFinishPoint + 1, errorTextTemp.Length - codeFinishPoint - 1);
                    string errorMessageCheck = errorMessage.Replace("\n", "").Replace(" ", "");
                    int messageStartPoint = 0;
                    int messageFinishPoint = 0;

                    if (errorMessageCheck[0] == '\"')
                    {
                        errorMessage += "\"";
                        messageStartPoint = errorMessage.IndexOf("\"");
                        messageFinishPoint = errorMessage.LastIndexOf("\"");
                    }
                    else
                    {
                        errorMessage += "\'";
                        messageStartPoint = errorMessage.IndexOf("\'");
                        messageFinishPoint = errorMessage.LastIndexOf("\'");
                    }
                    errorMessage = errorMessage.Substring(messageStartPoint + 1, messageFinishPoint - messageStartPoint-1 );
                    ErrorListApi errorListManagement = new ErrorListApi();
                    errorListManagement.extendedErrorCode = errorCode;
                    errorListManagement.defaultDescription = errorMessage;
                    errorListManagements.Add(errorListManagement);
                    Console.WriteLine(errorListManagement.extendedErrorCode + ":" + errorListManagement.defaultDescription);
                }


        }
    }
}
