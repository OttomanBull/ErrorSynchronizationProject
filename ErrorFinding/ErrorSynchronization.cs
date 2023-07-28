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
        public List<JToken> GetErrorWillBeAdded(List<JToken> apiErrorList,JToken toCompare)
        {
            JToken errorListToCompare = toCompare.SelectToken("errorCodes");
            List<JToken> willBeAdded = new List<JToken>();

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

            return willBeAdded;
        }

        public List<JToken> GetWillBeRemovedFromUi(List<JToken> apiErrorList, JToken toCompare)
        {
            JToken errorListToCompare = toCompare.SelectToken("errorCodes");
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


        public JToken AddErrorToJson(List<JToken> apiErrorList, JToken toCompare)
        {
            List<JToken> errorListWillBeAdded = GetErrorWillBeAdded(apiErrorList, toCompare);
            
            foreach(JToken error in errorListWillBeAdded)
            {
                JObject errorObject = toCompare as JObject;
                JProperty errorProp= error as JProperty;
                string description =(string) error.Parent.SelectToken("defaultDescription");
                errorObject["errorCodes"][errorProp.Value.ToString()] =description;
            }
            return toCompare;
        }

        public JToken RemoveErrorFromJson(List<JToken> apiErrorList, JToken toCompare)
        {
            JToken errorListUi = AddErrorToJson(apiErrorList,toCompare);
            List<JToken> errorListWillBeRemove = GetWillBeRemovedFromUi(apiErrorList, toCompare);
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
