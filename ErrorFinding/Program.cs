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
        List<ErrorListApi> errorListApi = new List<ErrorListApi>();
        //Console.WriteLine("api list başlangıçtaki boyutu:" + errorListApi.Count);
        List<ErrorListApi> errorListManagement = new List<ErrorListApi>();

        ErrorListDal errorListDal = new ErrorListDal();
        errorListDal.GetErrorListApi(errorListApi);
        errorListDal.GetErrorListManagement("https://raw.githubusercontent.com/xyztek/CrowdFundingManagement/master/src/lang/errorCodes/tr_TR.js?token=GHSAT0AAAAAACDY22CZPG2LQ4L55NMEMVYEZFQAHNA", errorListManagement);

        Compare compare=new Compare();       
        compare.compareErrors(errorListApi,errorListManagement);
        Console.WriteLine("management listesi boyutu:"+errorListManagement.Count);
        Console.WriteLine("api listesi boyutu:" + errorListApi.Count);

        
    }


}





