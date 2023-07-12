using System.IO;
using System.Net;
using ErrorFinding;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {

        List<ErrorListApi> errorListApi = new List<ErrorListApi>();
        List<ErrorListManagement> errorListManagement = new List<ErrorListManagement>();

        ErrorListDal errorListDal = new ErrorListDal();
        errorListDal.GetErrorListApi(errorListApi);
        //errorListDal.GetErrorListUI();
        errorListDal.GetErrorListManagement("C://Users//Elif Aslan//Desktop//errorSynk//ErrorSynchronizationProject//ErrorFinding//ErrorFolders//tr_TR.js",errorListManagement);

        Compare compare=new Compare();
        compare.compareErrors(errorListApi,errorListManagement);

        Console.WriteLine("api:"+errorListApi.Count);
        Console.WriteLine("management:" + errorListManagement.Count);
    }

    
}


    
    

