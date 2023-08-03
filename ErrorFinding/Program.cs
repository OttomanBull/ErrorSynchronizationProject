using System.Collections;
using System.Collections.Generic;
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
       // toFolder.ChangeManagementFile();
        toFolder.ChangeUIFile();
        gitProccesCompiler.GitPushOperation();

        var configuration = new ConfigurationBuilder()
          .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
          .Build();
    }
}



    
    

