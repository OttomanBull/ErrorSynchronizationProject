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
        errorListDal.GetErrorListManagement("C:\\Users\\Work and Study\\Documents\\GitHub\\ErrorSynchronizationProject\\ErrorFinding\\ErrorFolders\\en_US.js");



    }
}


    
    

