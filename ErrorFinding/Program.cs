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
        List<IErrorList> liste3 = new List<IErrorList>();


        ErrorListDal errorListDal = new ErrorListDal();
        //var errorListApi =errorListDal.GetErrorListApi();
        var errorListUI= errorListDal.GetErrorListUI();


        errorListDal.GetErrorListApi();

        List<KeyValuePair<string, string>> myList = new List<KeyValuePair<string, string>>();
        //myList = (List<KeyValuePair<string, string>>)errorListUI.Except(errorListApi);
        //errorListDal.GetErrorListManagement("C:\\Users\\Work and Study\\Documents\\GitHub\\ErrorSynchronizationProject\\ErrorFinding\\ErrorFolders\\en_US.js");








    }
}


    
    

