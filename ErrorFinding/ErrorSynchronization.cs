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
        public List<JToken> GetErrorWillBeAddedToUi()
        {
            ErrorListDalJson errorListDal = new ErrorListDalJson();
            List<JToken> apiErrorList = errorListDal.GetErrorListApi();
            JToken errorListToCompare = errorListDal.GetErrorListUI();
            List<JToken> willBeAdded = new List<JToken>();
            Console.WriteLine(errorListToCompare.Count());

            foreach (JToken apiError in apiErrorList.Children())
            {
                JProperty errorProperty = apiError as JProperty;
                bool found = false;
                string description = "";
                if (errorProperty.Name == "defaultDescription")
                {
                    description = errorProperty.Value.ToString();
                }
                if (errorProperty.Name == "extendedErrorCode")
                {
                    foreach (JToken errorToCompare in errorListToCompare)
                    {
                        JProperty errorToCompareProperty = errorToCompare as JProperty;

                        if (errorProperty.Value.ToString().Equals(errorToCompareProperty.Name.ToString()))
                        {
                            found = true;
                        }
                    }
                    if (!found)//eklenecek
                    {
                        willBeAdded.Add(apiError);
                        JObject errorObject = errorListToCompare as JObject;
                        errorObject["errorCodes"][errorProperty.Name] = JObject.Parse(description);
                    }
                }
            }
            Console.WriteLine(errorListToCompare.Count());

            return willBeAdded;
        }

        public List<JToken> GetWillBeRemovedFromUi()
        {
            ErrorListDalJson errorListDal = new ErrorListDalJson();
            List<JToken> apiErrorList = errorListDal.GetErrorListApi();
            JToken errorListToCompare = errorListDal.GetErrorListUI();
            List<JToken> willBeRemoved = new List<JToken>();

            bool found = false;

            foreach (JToken errorToCompare in errorListToCompare)
            {
                JProperty errorToCompareProperty = errorToCompare as JProperty;

                foreach (JToken apiError in apiErrorList.Children())
                {
                    JProperty apiErrorProperty = apiError as JProperty;
                    if (apiErrorProperty.Name == "extendedErrorCode")
                    {
                        if (apiErrorProperty.Value.ToString().Equals(errorToCompareProperty.Name.ToString()))
                        {
                            found = true;
                        }
                    }
                }
                if (!found)//silinecek
                {
                    willBeRemoved.Add(errorToCompare);
                }
            }

            return willBeRemoved;
        }
    }
}
