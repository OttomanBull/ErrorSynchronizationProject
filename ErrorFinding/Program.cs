using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using ErrorFinding;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        GitProcessCompilerv2 gitProcessCompilerv2 = new GitProcessCompilerv2();
        ToFolder toFolder = new();
        gitProcessCompilerv2.GitCloneOperation();
        gitProcessCompilerv2.GitPullOperation();
        toFolder.ChangeUIFile();
        gitProcessCompilerv2.GitPushOperation();
         

    }
}



    
    

