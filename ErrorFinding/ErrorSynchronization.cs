using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorFinding
{
    public class ErrorSynchronization
    {
        public List<ErrorList> ErrorCodeComparison(List<ErrorList> list1, List<ErrorList> list2)
        {
            List<string> extendedErrorCodes1 = list1.Select(x => x.extendedErrorCode).ToList();
            List<string> extendedErrorCodes2 = list2.Select(x => x.extendedErrorCode).ToList();

            List<string> uniqueExtendedErrorCodes = extendedErrorCodes1.Except(extendedErrorCodes2).ToList();

            List<ErrorList> uniqueErrors = list1.Where(x => uniqueExtendedErrorCodes.Contains(x.extendedErrorCode)).ToList();

            return uniqueErrors;
        }


    }
}
