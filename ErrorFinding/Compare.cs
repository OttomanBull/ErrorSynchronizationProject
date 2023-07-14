using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorFinding
{
    public class Compare
    {  
        public void compareErrors(List<ErrorListApi> apiErrors, List<ErrorListApi> compareErrors)
        {
            Console.WriteLine("managament'a  eklenecek errorlar");
            foreach (ErrorListApi apiError in apiErrors.ToList()){
                bool found = false;
                foreach (ErrorListApi compareError in compareErrors){   
                    if (apiError.extendedErrorCode.Equals(compareError.extendedErrorCode)){  //api'daki error uı'da var
                        found = true;
                    }
                    else //management'da yok
                    {}
                }
                if (!found){
                    ErrorListApi newError = new ErrorListApi();
                    newError.extendedErrorCode = apiError.extendedErrorCode;
                    newError.defaultDescription = apiError.defaultDescription;
                    compareErrors.Add(newError);
                    Console.WriteLine(apiError.extendedErrorCode);
                }
            }
            Console.WriteLine("managament'dan çıkartılacak errorlar");
            foreach (ErrorListApi compareError in compareErrors.ToList()){
                bool found = false;
                foreach (ErrorListApi apiError in apiErrors){   //uı'daki error api'da var
                    if (compareError.extendedErrorCode.Equals(apiError.extendedErrorCode)){
                        found = true;
                    }
                    else //api'da yok
                    {}
                }
                if (!found){
                    compareErrors.Remove(compareError);
                    Console.WriteLine(compareError.extendedErrorCode);
                }
            }
        }
    }
}
