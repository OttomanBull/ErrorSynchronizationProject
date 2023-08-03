using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using ErrorFinding;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        GitProccesCompiler gitProccesCompiler = new();   
        ToFolder toFolder = new();
        //gitProccesCompiler.GitPullOperation();
        toFolder.ChangeManagementFile();
        toFolder.ChangeUIFile();
        // gitProccesCompiler.GitPushOperation();
        Console.WriteLine("test");
        Console.WriteLine("test2");
    }
}



    
    

