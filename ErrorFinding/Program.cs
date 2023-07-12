using System.IO;
using System.Net;
using ErrorFinding;
using Newtonsoft.Json;

//hata mesajlarının istediğim yerlerini atabilmek için bir obje oluşturdum.

class Program
{
    static void Main()
    {
        ErrorListDal errorListDal = new ErrorListDal();
        //errorListDal.GetErrorListApi();
        //errorListDal.GetErrorListUI();
        errorListDal.GetErrorListManagement("C://Users//Elif Aslan//Desktop//errorSynk//ErrorSynchronizationProject//ErrorFinding//ErrorFolders//tr_TR.js");



    }
}


    
    

