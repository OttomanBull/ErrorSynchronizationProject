using Microsoft.Extensions.Configuration;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;
using System.Threading;

namespace ErrorFinding
{
    public class GitProccesCompiler
    {
     

        private async Task PowerShellGitOperationsAsync(string directory,string githubHTTPSURL)
        {
            using (PowerShell powershell = PowerShell.Create())
            {
                powershell.AddScript($"cd {directory}");

                if (!File.Exists(Path.Combine(directory + "\\jsconfig.json")))
                {
                    powershell.AddScript($"git clone {githubHTTPSURL}");
                    await powershell.InvokeAsync();
                }
                powershell.AddScript("cd CrowdFundingUI");
                await powershell.InvokeAsync();
                powershell.AddScript(@"git checkout master");
                await powershell.InvokeAsync();
                powershell.AddScript(@"git pull");
                await powershell.InvokeAsync();
                powershell.AddScript($"git checkout -b ErrorTestv1");
                await powershell.InvokeAsync();
                Collection<PSObject> results = powershell.Invoke();
        
            }
        }
        public void GitPullOperation() 
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appSettings.json", false, true).Build();

            string directory = configuration.GetSection("ProjectDirectory:CrowdFundingUIDirectory").Value; ;
            string githubHTTPSURL = configuration.GetSection("GithubHTTPS:UIHTTPS").Value;
            var result = PowerShellGitOperationsAsync(directory, githubHTTPSURL);

        }
        public async Task GitPushOperationAsync()
        {           
            using (PowerShell powershell = PowerShell.Create())
            {             
                powershell.AddScript(@"git commit -a -m ‘git Error Code İşlemleri Yapıldı v2’ ");
                await powershell.InvokeAsync();
                powershell.AddScript(@"git push origin ErrorTestv1 ");
                await powershell.InvokeAsync();
            }
        }
    }
}
