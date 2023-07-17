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
        ErrorSynchronization errorSynchronization = new();
        errorSynchronization.ShowUpdateUIErrorList();
    }
}


    
    

