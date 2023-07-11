using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorFinding
{
    internal class ErrorListManagement:IErrorList
    {
        public string extendedErrorCode { get; set; }
        public string defaultDescription { get; set; }
    }
}
