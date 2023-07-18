using System.Globalization;
using System.IO;
using System.Net;
using ErrorFinding;
using Google.Apis.Translate.v2.Data;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
               
        /*ErrorListDal errorListDal = new ErrorListDal();
        List<ErrorList> errorListApi = errorListDal.GetErrorListApi();
        List<ErrorList> errorListManagement = errorListDal.GetErrorListManagement("https://raw.githubusercontent.com/xyztek/CrowdFundingManagement/master/src/lang/errorCodes/tr_TR.js");

        Compare compare=new Compare();       
        compare.compareErrors(errorListApi,errorListManagement);*/

        ToFolder toFolder=new ToFolder();
        toFolder.ToManagementFile();
    }

}





