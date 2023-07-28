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

        ToFolder toFolder = new ToFolder();
        string managementText=toFolder.ToManagementFile("https://raw.githubusercontent.com/xyztek/CrowdFundingManagement/master/src/lang/errorCodes/tr_TR.js");
        JToken uiJson = toFolder.toUi("https://raw.githubusercontent.com/xyztek/CrowdFundingUI/master/src/shared/language/english.json");
        Console.WriteLine(uiJson);
        //Console.WriteLine(managementText);

    }
}


    
    

