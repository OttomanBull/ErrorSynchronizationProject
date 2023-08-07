using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace ErrorFinding
{
    public class GitProcessCompiler
    {
        private static string GetAppSettingsLocation(string appSettingsKey, string appSettingsValue)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appSettings.json", false, true).Build();
            string location = configuration.GetSection($"{appSettingsKey}:{appSettingsValue}").Value;
            string character = "\"";
            location = character + location + character;
            return location;
        }
        
        public void GitCloneOperation()
        {
            if (!File.Exists("C:\\Users\\Work and Study\\Documents\\GitHub\\CrowdFundingUI\\package.json"))
            {
                using (var powershell = PowerShell.Create())
                {
                    powershell.AddScript($"cd {GetAppSettingsLocation("ProjectDirectory", "CrowdFundingDirectory")}");
                    powershell.AddScript($"git clone {GetAppSettingsLocation("GithubHTTPS", "UIHTTPS")} ");
                    powershell.Invoke();            
                }
            }
        }
        public void GitPullOperation()
        {
            using (var powershell = PowerShell.Create())
            {
                powershell.AddScript($"cd {GetAppSettingsLocation("ProjectDirectory", "CrowdFundingUIDirectory")}");
                powershell.AddScript(@"git checkout master");
                powershell.AddScript(@"git pull");
                powershell.AddScript($"git checkout -b ErrorTestv1");
                powershell.Invoke();
            }
        }
        public void GitPushOperation()
        {
            using (var powershell = PowerShell.Create())
            {
                powershell.AddScript($"cd {GetAppSettingsLocation("ProjectDirectory", "CrowdFundingUIDirectory")} ");
                powershell.AddScript(@"git checkout ErrorTestv1");
                powershell.AddScript(@"git commit -a -m ""git Error Code İşlemleri Yapıldı v2"" ");
                powershell.AddScript(@"git push origin ErrorTestv1 ");
                powershell.Invoke();
            }
        }
    }
}
