using System.Globalization;
using System.IO;
using System.Net;
using ErrorFinding;
using Google.Apis.Translate.v2.Data;
using Newtonsoft.Json;
//using Google.Cloud.Translate.V2;

class Program
{
    static void Main()
    {
               
        /*ErrorListDal errorListDal = new ErrorListDal();
        List<ErrorList> errorListApi = errorListDal.GetErrorListApi();
        List<ErrorList> errorListManagement = errorListDal.GetErrorListManagement("https://raw.githubusercontent.com/xyztek/CrowdFundingManagement/master/src/lang/errorCodes/tr_TR.js");

        Compare compare=new Compare();       
        compare.compareErrors(errorListApi,errorListManagement);
        Console.WriteLine("management listesi boyutu:"+errorListManagement.Count);
        Console.WriteLine("api listesi boyutu:" + errorListApi.Count);*/
        //ReadUrl write =new ReadUrl();
        //write.writeToUrl("C:/Users/Elif Aslan/Desktop/test.txt");

        ToFolder toFolder=new ToFolder();
        toFolder.ToManagement();
    }


}





