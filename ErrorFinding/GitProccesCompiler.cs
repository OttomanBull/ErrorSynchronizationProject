using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;

namespace ErrorFinding
{
    public class GitProccesCompiler
    {
        private void PowerShellGitOperations(string directory, string fileName)
        {
            string name = "Bahadır";
            int dateTime = 1;
            string lastName = name + dateTime;
            string githubSSHURL = "git@github.com:OttomanBull/ErrorSynchronizationProject.git";

            using (PowerShell powershell = PowerShell.Create())
            {
                powershell.AddScript($"cd {directory}");

                if (!File.Exists(Path.Combine(directory, fileName)))
                    powershell.AddScript($"git clone {githubSSHURL}");

                powershell.AddScript(@"git checkout BahadirBranch");
                
                powershell.AddScript(@"git pull");


                powershell.AddScript($"git checkout -b {lastName}");

                Collection<PSObject> results = powershell.Invoke();

                dateTime++;
            }
        }

        public void GitPullOperation() 
        {
            string fileName =  @"ErrorFinding.sln";
            string directory = @"C:\Users\Work and Study\Documents\GitHub\ErrorSynchronizationProject";

            PowerShellGitOperations(directory, fileName);
        }

        public void GitPushOperation()
        {
            string name = "Bahadır";
            int dateTime = 1;
            string lastName = name + dateTime;
            using (PowerShell powershell = PowerShell.Create())
            {
                powershell.AddScript(@"git commit -m ‘Error Code İşlemleri Yapıldı’ ");
                powershell.AddScript($"git push origin {lastName} ");
                powershell.AddScript($"git merge BahadirBranch ");
            }
        }

    }
}
