using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorFinding
{
    public class Compare
    {  
        public void compareErrors(List<ErrorListApi> apiErrors, List<ErrorListManagement> compareErrors)
        {
            //add
            int count = 0;
            foreach (ErrorListApi apiError in apiErrors)
            {
                bool found = false;
                foreach (ErrorListManagement compareError in compareErrors)
                {   //api'daki error uı'da var
                    if (apiError.extendedErrorCode.Equals(compareError.extendedErrorCode))
                    {
                        found = true;
                    }
                    else //uı'da yok
                    {
                    }
                }
                if (found == false)
                {
                    ErrorListManagement newError = new ErrorListManagement();
                    newError.extendedErrorCode = apiError.extendedErrorCode;
                    newError.defaultDescription = apiError.defaultDescription;
                    compareErrors.Add(newError);
                }
            }
            //remove
            foreach (ErrorListManagement compareError in compareErrors.ToList())
            {
                bool found = false;
                foreach (ErrorListApi apiError in apiErrors)
                {   //uı'daki error api'da var
                    if (compareError.extendedErrorCode.Equals(apiError.extendedErrorCode))
                    {
                        found = true;
                    }
                    else //api'da yok
                    {
                    }
                }
                if (found == false)
                {
                    compareErrors.Remove(compareError);
                }
            }

        }
    }
}
