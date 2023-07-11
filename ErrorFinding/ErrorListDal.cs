using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ErrorFinding
{
    public class ErrorListDal
    {
        public void GetErrorListApi()
        {
            List<List<string>> errorCodesAndMessages = new List<List<string>>();
            //verileri nereden alıcağımı programa göstermek için bir url tanımladım
            string url = "https://developmentapi.fonhub.xyzteknoloji.com/api/errorrecord/all";
            //WebClient kullnarak json dosyasındaki verileri convert edip indiriyoruz
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    string json = webClient.DownloadString(url);
                    //indirdiğimiz verilerin ErrorList adlı bir listeye convert edilerek gitmesini istediğimizi belirttik
                    ErrorListApi[] errorList = JsonConvert.DeserializeObject<ErrorListApi[]>(json);

                    // JSON verileri C# nesnesine dönüştürüldü, artık errorList dizisi üzerinden kullanabiliriz

                    // Verilerin hepsini konsola yazdırıyoruz

                    foreach (ErrorListApi error in errorList)
                    {
                        //errorCodesAndMessages.Add();
                        //errorCodesAndMessages[0].Add(error.defaultDescription);
                        Console.WriteLine("Extended Error Code: " + errorCodesAndMessages);
                        Console.WriteLine("Default Description: " + errorCodesAndMessages[0]);
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
    }