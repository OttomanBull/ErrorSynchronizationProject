using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using ErrorFinding;
using Newtonsoft.Json;



class Program
{
    static void Main()
    {
        List<ErrorList> liste3 = new List<ErrorList>();

        ErrorSynchronization errorSynchronization = new ErrorSynchronization();
        ErrorListDal errorListDal = new ErrorListDal();
        var errorListApi = errorListDal.GetErrorListApi();

        
        List<ErrorList> WillBeAddedUI = errorSynchronization.ErrorCodeComparison(errorListDal.GetErrorListApi(), errorListDal.GetErrorListUI());
        List<ErrorList> ToBeRemovedUI = errorSynchronization.ErrorCodeComparison(errorListDal.GetErrorListUI(), errorListDal.GetErrorListApi());
        int AddedCount = WillBeAddedUI.Count;
        int RemovedCount = ToBeRemovedUI.Count;

        Console.WriteLine("Apide olup UI da olmayanlar");
        Console.WriteLine("");
        foreach (var item in ToBeRemovedUI)
        {
            Console.WriteLine(item.extendedErrorCode);
            Console.WriteLine(item.defaultDescription);
            Console.WriteLine("");
        }


        Console.WriteLine("UIda olup Apide olmayanlar");
        Console.WriteLine("");
        foreach (var item in WillBeAddedUI)
        {
            Console.WriteLine(item.extendedErrorCode);
            Console.WriteLine(item.defaultDescription);
            Console.WriteLine("");
        }

        Console.WriteLine("UI a eklenecek kod sayısı= " + AddedCount);
        Console.WriteLine("UI dan silinecek kod sayısı= " + RemovedCount);

        errorListDal.GetErrorListUI();







    }
}


    
    

