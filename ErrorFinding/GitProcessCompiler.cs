using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
        public static void GitCloneOperation()
        {
            if (!File.Exists("C:\\Users\\Work and Study\\Documents\\GitHub\\CrowdFundingUI\\package.json"))
            {
                using var powershell = PowerShell.Create();
                powershell.AddScript($"cd \"{GetAppSettingsLocation("ProjectDirectory", "CrowdFundingDirectory")}\" ");
                powershell.AddScript($"git clone \"{GetAppSettingsLocation("GithubHTTPS", "UIHTTPS")}\" ");
                Console.WriteLine("Clone İşlemi Yapılıyor");
                powershell.Invoke();
            }
        }
        public static void GitPullOperation()
        {
            using var powershell = PowerShell.Create();
            powershell.AddScript($"cd \"{GetAppSettingsLocation("ProjectDirectory", "CrowdFundingUIDirectory")}\" ");
            powershell.AddScript(@"git checkout master");
            powershell.AddScript(@"git pull");
            powershell.AddScript($"git checkout -b \"{BranchName()}\" ");
            Console.WriteLine("Pull işlemi yapılıyor");
            powershell.Invoke();
        }
        public static void GitPushOperation()
        {
            using var powershell = PowerShell.Create();
            powershell.AddScript($"cd \"{GetAppSettingsLocation("ProjectDirectory", "CrowdFundingUIDirectory")}\" ");
            powershell.AddScript($"git checkout \"{BranchName()}\" ");
            powershell.AddScript(@"git commit -a -m ""git Error Code İşlemleri Yapıldı v2"" ");
            powershell.AddScript($"git push origin \"{BranchName()}\" ");
            Console.WriteLine("Push İşlemi yapılıyor");
            powershell.Invoke();
        }

        //bir sonraki aşamada ağacın tamamını gezip gelen key'in valuesi dönülecek!
        public static string GetAppSettingsLocation(string appSettingsKey, string appSettingsValue)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appSettings.json", false, true).Build();
            string location = configuration.GetSection($"{appSettingsKey}:{appSettingsValue}").Value;
            return location;
        }

        public static string BranchName()
        {
            string errorCodeBranchName = "ErrorCodeUpdate-";
            DateTime dateTime = DateTime.Now;
            string errorCodeUpdateTime = dateTime.Day.ToString("00")+"-"+dateTime.Month.ToString("00")+"-"+dateTime.Year.ToString()+"-"+dateTime.Hour.ToString("00")+"-"+dateTime.Minute.ToString("00");
            string branchName = errorCodeBranchName + errorCodeUpdateTime;
            return branchName;
        }

    }
}
