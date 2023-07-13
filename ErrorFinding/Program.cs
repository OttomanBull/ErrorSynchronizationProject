using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using ErrorFinding;
using Newtonsoft.Json;

//hata mesajlarının istediğim yerlerini atabilmek için bir obje oluşturdum.

class Program
{
    static void Main()
    {
        List<ErrorList> liste3 = new List<ErrorList>();

        ErrorSynchronization errorSynchronization = new ErrorSynchronization();
        ErrorListDal errorListDal = new ErrorListDal();
        var errorListApi = errorListDal.GetErrorListApi();

        
        List<ErrorList> MyErrorList = errorSynchronization.ErrorCodeComparison(errorListDal.GetErrorListApi(), errorListDal.GetErrorListUI());
        int count = MyErrorList.Count;

        foreach (var item in MyErrorList)
        {
            Console.WriteLine(item.extendedErrorCode);
            Console.WriteLine(item.defaultDescription);
            Console.WriteLine("");
        }

        Console.WriteLine("toplam farklılık sayısı=" + count);
        errorListDal.GetErrorListUI();







    }
}


    
    

