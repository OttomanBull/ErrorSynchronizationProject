using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ErrorFinding
{
    public class ReadUrl
    {
        public void readUrl(string url,string folderPath)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("Authorization: token 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");
                wc.Headers.Add("Accept: application / vnd.github.v3.raw");
                try
                {
                    wc.DownloadFile(url, @folderPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
