using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using ErrorFinding;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        /*ToFolder toFolder = new ToFolder();
       // toFolder.ToManagementFile();
        toFolder.ToUiFile();*/

        ErrorListDalJson errorListDalJson = new ErrorListDalJson();
        JToken errorListUi = errorListDalJson.GetErrorListUIJson();
        JToken errorListApi= errorListDalJson.GetErrorListApiJson();
        ErrorSynchronization errorSynchronization = new ErrorSynchronization();
        errorSynchronization.ErrorCodeUpateVBahadir(errorListApi,errorListUi);
     
       


    }
}


    
    

