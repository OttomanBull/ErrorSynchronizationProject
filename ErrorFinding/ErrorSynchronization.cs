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
            JToken result = errorListDal.GetErrorListUI();
            JToken errorListToCompare = result.SelectToken("errorCodes");
            List<JToken> willBeAdded = new List<JToken>();
            Console.WriteLine(errorListToCompare.Count());

            foreach (JToken apiError in apiErrorList.Children())
            {
                JProperty apiErrorProperty = apiError as JProperty;

                bool found = false;

                if (apiErrorProperty.Name == "extendedErrorCode")
                {
                    foreach (JToken errorToCompare in errorListToCompare)
                    {
                        JProperty errorToCompareProperty = errorToCompare as JProperty;

                        if (apiErrorProperty.Value.ToString().Equals(errorToCompareProperty.Name.ToString()))
                        {
                            found = true;
                        }
                    }
                    if (!found)//eklenecek
                    {
                        willBeAdded.Add(apiError);
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
            JToken result = errorListDal.GetErrorListUI();//tüm ui
            JToken errorListToCompare = result.SelectToken("errorCodes");
            List<JToken> willBeRemoved = new List<JToken>();

            bool found = false;

            foreach (JToken errorToCompare in errorListToCompare)
            {
                JProperty errorToCompareProperty = errorToCompare as JProperty;

                foreach (JToken apiError in apiErrorList.Children())
                {
                    /*JProperty apiErrorProperty = apiError as JProperty;
                    if (apiErrorProperty.Name == "extendedErrorCode")
                    {
                        if (apiErrorProperty.Value.ToString().Equals(errorToCompareProperty.Name.ToString()))
                        {
                            found = true;
                        }
                    }*/
                    Console.WriteLine(apiError);

                    /*if ((string)apiError.SelectToken("extendedErrorCode").Equals(errorToCompareProperty.Name.ToString()){

                    }*/
                }
                if (!found)//silinecek
                {
                    willBeRemoved.Add(errorToCompare);
                    Console.WriteLine(errorToCompareProperty.Name);   
                }
            }
            return willBeRemoved;
        }

        public JToken AddErrorToJson()
        {
            ErrorListDalJson errorListDalJson = new ErrorListDalJson();
            JToken errorListUi=errorListDalJson.GetErrorListUI();
            List<JToken> errorListWillBeAdded = GetErrorWillBeAddedToUi();
            
            foreach(JToken error in errorListWillBeAdded)
            {
                JObject errorObject = errorListUi as JObject;
                JProperty errorProp= error as JProperty;
                string description =(string) error.Parent.SelectToken("defaultDescription");
                errorObject["errorCodes"][errorProp.Value.ToString()] =description;
            }
            return errorListUi;
        }

        public JToken RemoveErrorFromJson()
        {
            JToken errorListUi = AddErrorToJson();
            List<JToken> errorListWillBeRemove = GetWillBeRemovedFromUi();
            JToken errorCodes = errorListUi.SelectToken("errorCodes");

            JObject errorObject = errorCodes as JObject;

            foreach (JToken error in errorListWillBeRemove)
            {
                JProperty jProperty= error as JProperty;
                errorObject.Property(jProperty.Name).Remove();
            }
            return errorListUi;
        }
    }
}
