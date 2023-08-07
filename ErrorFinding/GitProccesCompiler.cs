using Microsoft.Extensions.Configuration;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;
using System.Threading;

namespace ErrorFinding
{
    public class GitProccesCompiler
    {
        private bool PowerShellGitOperations(string directory,string githubHTTPSURL)
        {
            using (PowerShell powershell = PowerShell.Create())
            {
                powershell.AddScript($"cd {directory}");

                if (!File.Exists(Path.Combine(directory + "\\jsconfig.json")))
                {
                    powershell.AddScript($"git clone {githubHTTPSURL}");
                    Thread.Sleep(15000);
                }
                powershell.AddScript("cd CrowdFundingUI");
                Thread.Sleep(1000);
                powershell.AddScript(@"git checkout master");
                Thread.Sleep(1000);
                powershell.AddScript(@"git pull");
                Thread.Sleep(1000);
                powershell.AddScript($"git checkout -b ErrorTestv1");
                Thread.Sleep(1000);
                Collection<PSObject> results = powershell.Invoke();

                if (!results.Any())
                {
                    return false;
                }
                return true;                
            }
        }
        public void GitPullOperation() 
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appSettings.json", false, true).Build();

            string directory = configuration.GetSection("ProjectDirectory:CrowdFundingUIDirectory").Value; ;
            string githubHTTPSURL = configuration.GetSection("GithubHTTPS:UIHTTPS").Value;
            var result = PowerShellGitOperations(directory, githubHTTPSURL);

            if (!result)
            {
                new ArgumentNullException(nameof(githubHTTPSURL), $"{githubHTTPSURL} adresindeki repository {directory} konumuna kayıt edilemedi !");
            }
        }
        public void GitPushOperation()
        {           
            using (PowerShell powershell = PowerShell.Create())
            {             
                powershell.AddScript(@"git commit -a -m ""git Error Code İşlemleri Yapıldı v2"" ");
                Thread.Sleep(30000);
                powershell.AddScript(@"git push origin ErrorTestv1 ");
                Thread.Sleep(30000);
            }
        }
    }
}
