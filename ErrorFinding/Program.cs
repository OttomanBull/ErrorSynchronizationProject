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


        ErrorListDal errorListDal = new ErrorListDal();
        //var errorListApi =errorListDal.GetErrorListApi();

        List<ErrorList> MyErrorList = errorListDal.ErrorCodeComparison2(errorListDal.GetErrorListApi(), errorListDal.GetErrorListUI());
        int count=MyErrorList.Count;

        foreach (var item in MyErrorList)
        {
            Console.WriteLine(item.extendedErrorCode);
            Console.WriteLine(item.defaultDescription);
            Console.WriteLine("");
        }
       
        Console.WriteLine("toplam farklılık sayısı="+ count);








    }
}


    
    

