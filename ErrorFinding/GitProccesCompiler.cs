using Microsoft.Extensions.Configuration;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;
using System.Threading;

namespace ErrorFinding
{
    public class GitProccesCompiler
    {
        private void PowerShellGitOperations(string directory,string gitHubSSHURl)
        {
           
            string githubSSHURL = gitHubSSHURl;

            using (PowerShell powershell = PowerShell.Create())
            {
                powershell.AddScript($"cd {directory}");

                if (!File.Exists(Path.Combine(directory+ "\\jsconfig.json")))
                powershell.AddScript($"git clone {githubSSHURL}");

                powershell.AddScript(@"git checkout master");
                
                powershell.AddScript(@"git pull");


                powershell.AddScript($"git checkout -b ErrorTestv1");

                Collection<PSObject> results = powershell.Invoke();

             
            }
        }
        public void GitPullOperation() 
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appSettings.json", false, true).Build();

            string directory = @"C:\Users\Work and Study\Documents\GitHub\CrowdFundingUI-master";
            string gitHubSSHURL = configuration.GetSection("url:UiEnUrl").Value;
            PowerShellGitOperations(directory, gitHubSSHURL);
        }
        public void GitPushOperation()
        {
           
            using (PowerShell powershell = PowerShell.Create())
            {
              
                powershell.AddScript(@"git commit -a -m ‘git Error Code İşlemleri Yapıldı v2’ ");
                Thread.Sleep(15000);
                powershell.AddScript(@"git push origin ErrorTestv1 ");
                Thread.Sleep(15000);
            }
        }
    }
}
