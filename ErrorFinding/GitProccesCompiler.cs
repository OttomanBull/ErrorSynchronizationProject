using System.Collections.ObjectModel;
using System.Management.Automation;

namespace ErrorFinding
{
    public class GitProccesCompiler
    {
        public void deneme() 
        {
            string directory = "C:\\Users\\Work and Study\\Documents\\GitHub\\ErrorSynchronizationProject"; // directory of the git repository

            using (PowerShell powershell = PowerShell.Create())
            {
                // this changes from the user folder that PowerShell starts up with to your git repository
                powershell.AddScript($"cd {directory}");

                powershell.AddScript(@"git checkout master");

                powershell.AddScript(@"git pull");

                Collection<PSObject> results = powershell.Invoke();
            }
        }
    }
}
