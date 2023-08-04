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
        GitProccesCompiler gitProccesCompiler = new();   
        ToFolder toFolder = new();
        gitProccesCompiler.GitPullOperation();
        toFolder.ChangeUIFile();
     //   toFolder.ChangeManagementFile();
        gitProccesCompiler.GitPushOperation();

    }
}



    
    

