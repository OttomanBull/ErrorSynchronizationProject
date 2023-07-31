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
            int value = 10;
            string lastName = name + value;
            string githubSSHURL = "git@github.com:OttomanBull/ErrorSynchronizationProject.git";

            using (PowerShell powershell = PowerShell.Create())
            {
                powershell.AddScript($"cd {directory}");

                if (!File.Exists(Path.Combine(directory, fileName)))
                    powershell.AddScript($"git clone {githubSSHURL}");

                powershell.AddScript(@"git checkout bahadirv3");
                
                powershell.AddScript(@"git pull");


                powershell.AddScript($"git checkout -b {lastName}");

                Collection<PSObject> results = powershell.Invoke();
            }
        }

        public void deneme() 
        {
            string fileName =  @"ErrorFinding.sln";
            string directory = @"C:\Users\Work and Study\Documents\GitHub\ErrorSynchronizationProject";

            PowerShellGitOperations(directory, fileName);
        }

        
        
        
    }
}
