using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorFinding
{
    public interface IErrorList
    {
        public string ExtendedErrorCode { get; set; }
        public string DefaultDescription { get; set; }

    }
}
