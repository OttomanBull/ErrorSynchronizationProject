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
     
        public IEnumerable<ErrorList> ErrorCodeComparisonVBahadir(IEnumerable<ErrorList> compareSource, IEnumerable<ErrorList> compareAgainst)
        {
            return compareSource.ExceptBy(compareAgainst.Select(i => i.extendedErrorCode), errorList => errorList.extendedErrorCode);
        }

        public List<ErrorList> ErrorCodeUpateVBahadir(IEnumerable<ErrorList> list1, IEnumerable<ErrorList> list2)
        {
            var willBeAddedUI = ErrorCodeComparisonVBahadir(list1, list2).ToList();
            var ToBeRemovedUI = ErrorCodeComparisonVBahadir(list2, list1).ToList();

            //var updateList = new List<ErrorList>();
            List<ErrorList> updateList = list2.ToList();

            updateList.AddRange(willBeAddedUI);

            foreach (var error in ToBeRemovedUI)
            {
                updateList.RemoveAll(e => e.extendedErrorCode == error.extendedErrorCode);
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
