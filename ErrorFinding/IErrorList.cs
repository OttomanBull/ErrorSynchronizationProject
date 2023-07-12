using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorFinding
{
    public interface IErrorList
    {
        public string extendedErrorCode { get; set; }
        public string defaultDescription { get; set; }

       
    }
}
