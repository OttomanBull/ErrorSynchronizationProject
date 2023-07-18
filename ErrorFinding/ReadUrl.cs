using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ErrorFinding
{
    public class ReadUrl
    {
        public string readUrl(string url)
        {
            string content="";
            using (HttpClient wc = new HttpClient())
            {
                wc.DefaultRequestHeaders.Add("Authorization","token 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");
                wc.DefaultRequestHeaders.Add("Accept", "application / vnd.github.v3.raw");
                try
                {
                    content=wc.GetStringAsync(url).Result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                return content;
            }
        }

        public void writeToUrl(string folderPath) {
            using (HttpClient wc = new HttpClient())
            {
                wc.DefaultRequestHeaders.Add("Authorization", "token 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");
                wc.DefaultRequestHeaders.Add("Accept"," application / vnd.github.v3.raw");
                wc.DefaultRequestHeaders.Add("User-Agent", "PUT");

                try
                {
                     byte[] fileContents=File.ReadAllBytes(folderPath);
                     string base64FileContents = Convert.ToBase64String(fileContents);
                     string fileContentsJson= "{\"message\":\"File Upload\",\"content\":\"" + base64FileContents + "\"}";
                     //string response = wc.UploadString($"https://api.github.com/repos/{"elifaslnn"}/{"cpp"}/contents/tr", "PUT", fileContentsJson);
                     Console.WriteLine("GONDERILDI");
                   
                    //mevcut dosya içeriğini alın
                    /*string response = wc.DownloadString("");
                    dynamic fileData = Newtonsoft.Json.JsonConvert.DeserializeObject(response);
                    string currentContent = fileData.content;
                    string currentSha = fileData.sha;

                    // Güncellenmiş içeriği belirleyin
                    string updatedContent = "This is the updated content of the file.";

                    // Base64 kodlama kullanarak içeriği şifreleyin
                    byte[] encodedBytes = System.Text.Encoding.UTF8.GetBytes(updatedContent);
                    string base64Content = Convert.ToBase64String(encodedBytes);

                    // GitHub API'ye gönderilecek veriyi oluşturun
                    string updateData = @"{""message"":""File Update"",""content"":""" + base64Content + @""",""sha"":""" + currentSha + @"""}";

                    // GitHub API'ye PUT isteği gönderin
                    string updateResponse = wc.UploadString(apiUrl, "PUT", updateData);
                    Console.WriteLine("Dosya başarıyla güncellendi!");*/
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
