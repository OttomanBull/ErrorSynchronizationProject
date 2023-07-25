using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ErrorFinding
{

    public class ErrorSynchronization
    {
     
        public JArray ErrorCodeComparisonVBahadir(JArray compareSource, JArray compareAgainst)
        {
            return (JArray)compareSource.Except(compareAgainst);
        }

        public JArray ErrorCodeUpateVBahadir(JArray list1, JArray list2)
        {
            JArray willBeAddedUI = ErrorCodeComparisonVBahadir(list1, list2);
            JArray ToBeRemovedUI = ErrorCodeComparisonVBahadir(list2, list1);

            // JToken nesneleri değiştirilemez olduğundan, bunları başka bir koleksiyona eklemek gerekebilir.
            // Örneğin, JArray kullanarak değiştirilebilir bir koleksiyon oluşturabilirsiniz.
            JArray updateList = new JArray(list2);

            foreach (JArray token in willBeAddedUI)
            {
                updateList.Add(token);
            }

            foreach (JArray token in ToBeRemovedUI)
            {
                updateList.Remove(token);
            }

            return updateList;
        }

        public List<ErrorList> compareErrorsVElif(List<ErrorList> apiErrors, List<ErrorList> compareErrors)
        {
            Console.WriteLine("managament'a  eklenecek errorlar");
            foreach (ErrorList apiError in apiErrors.ToList())
            {
                bool found = false;
                foreach (ErrorList compareError in compareErrors)
                {
                    if (apiError.extendedErrorCode.Equals(compareError.extendedErrorCode))
                    {  //api'daki error uı'da var
                        found = true;
                    }
                }
                if (!found)
                {
                    ErrorList newError = new ErrorList();
                    newError.extendedErrorCode = apiError.extendedErrorCode;
                    newError.defaultDescription = apiError.defaultDescription;
                    compareErrors.Add(newError);
                    Console.WriteLine(apiError.extendedErrorCode);
                }
            }
            Console.WriteLine("managament'dan çıkartılacak errorlar");
            foreach (ErrorList compareError in compareErrors.ToList())
            {
                bool found = false;
                foreach (ErrorList apiError in apiErrors)
                {   //uı'daki error api'da var
                    if (compareError.extendedErrorCode.Equals(apiError.extendedErrorCode))
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    compareErrors.Remove(compareError);
                    Console.WriteLine(compareError.extendedErrorCode);
                }
            }

            return compareErrors;
        }
    }
}
