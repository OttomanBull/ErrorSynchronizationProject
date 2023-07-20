using System.Collections;
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
        ErrorListDal errorListDal = new ErrorListDal();
        var errorSynchronization = new ErrorSynchronization();
        errorSynchronization.ShowUpdateUIErrorList();
        List<ErrorList> errors = new List<ErrorList>();
        errors = errorSynchronization.ErrorCodeUpate(errorListDal.GetErrorListApi(), errorListDal.GetErrorListUI());
        errorSynchronization.SaveToDesktop(errors);
    }
}


    
    

