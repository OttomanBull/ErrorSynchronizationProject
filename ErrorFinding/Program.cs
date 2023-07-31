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
        string managementText=toFolder.ToManagementFile("https://raw.githubusercontent.com/OttomanBull/ErrorSynchronizationProject/Bahad%C4%B1r/ErrorFinding/ErrorLists/ManEn.js");
        JToken uiJson = toFolder.toUi("https://raw.githubusercontent.com/OttomanBull/ErrorSynchronizationProject/Bahad%C4%B1r/ErrorFinding/ErrorLists/UIEn.json");
        //Console.WriteLine(uiJson);
        Console.WriteLine(managementText);

        string filePathUI = @"C:\Users\Work and Study\Documents\GitHub\ErrorSynchronizationProject\ErrorFinding\ErrorLists\UIEn.json";
        string filePathMan = @"C:\Users\Work and Study\Documents\GitHub\ErrorSynchronizationProject\ErrorFinding\ErrorLists\ManEn.js";
        // UIEn.json dosyasını sıfırlıyoruz.
        ClearJsonFile(filePathUI);
        ClearJsonFile(filePathMan);
        // UIEn.json dosyasını sıfırlıyoruz.
        WriteListToJsonFile(filePathUI, uiJson);
        WriteDataToJSFile(filePathMan, managementText);
        //GitProccesCompiler compiler = new GitProccesCompiler();
        //compiler.deneme();
    }
    static void ClearJsonFile(string filePath)
    {
        File.WriteAllText(filePath, string.Empty);
    }

    static void WriteListToJsonFile(string filePath, JToken dataList)
    {
        string json = JsonConvert.SerializeObject(dataList, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    static void WriteDataToJSFile(string filePath, string jsData)
    {
        File.WriteAllText(filePath, jsData);
    }

}



    
    

