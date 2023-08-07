using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ErrorFinding
{
    public class GitProcessCompilerv2
    {
       public  void GitCloneOperation()
        {
            using (var powershell = PowerShell.Create())
            {
                powershell.AddScript(@"cd ""C:\\Users\\Work and Study\\Documents\\GitHub"" ");
                powershell.AddScript(@"git clone ""https://github.com/xyztek/CrowdFundingUI.git"" ");
                powershell.Invoke();
            }

        }
        public  void GitPullOperation()
        {
            using (var powershell = PowerShell.Create())
            {
                powershell.AddScript(@"cd ""C:\\Users\\Work and Study\\Documents\\GitHub\\CrowdFundingUI""");
                powershell.AddScript(@"git checkout master");       
                powershell.AddScript(@"git pull");         
                powershell.AddScript($"git checkout -b ErrorTestv1");
                powershell.Invoke();
            }
        }
        public  void GitPushOperation()
        {
            using (var powershell = PowerShell.Create())
            {
                powershell.AddScript(@"cd ""C:\\Users\\Work and Study\\Documents\\GitHub\\CrowdFundingUI""");
                powershell.AddScript($"git checkout ErrorTestv1");
                powershell.AddScript(@"git commit -a -m ""git Error Code İşlemleri Yapıldı v2"" ");
                powershell.AddScript(@"git push origin ErrorTestv1 ");
                powershell.Invoke();

            }
        }
    }
}
