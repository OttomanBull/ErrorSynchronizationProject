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
        GitProcessCompiler gitProcessCompiler = new GitProcessCompiler();
        ToFolder toFolder = new();
        gitProcessCompiler.GitCloneOperation();
        gitProcessCompiler.GitPullOperation();
        toFolder.ChangeUIFile();
        gitProcessCompiler.GitPushOperation();
    }
}



    
    

