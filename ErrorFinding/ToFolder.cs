using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace ErrorFinding
{
    public class ToFolder
    {
        public string ToManagementFile(string url)
        {
            ErrorListDalJson errorListDalJson = new ErrorListDalJson();
            ErrorSynchronization errorSynchronization = new ErrorSynchronization();
            JToken listErrorManagement = errorSynchronization.RemoveErrorFromJson(errorListDalJson.GetErrorListApi(), errorListDalJson.GetErrorListManagement(url));
            JToken errorListToCompare = listErrorManagement.SelectToken("errorCodes");

            string errorText = "module.exports = { \n";

            foreach (var error in errorListToCompare)
            {
                JProperty errorProp= error as JProperty;
                errorText += $"{errorProp.Name}: \"{errorProp.Value}\",\n";
            }
            int lastComma= errorText.LastIndexOf(',');
            errorText=errorText.Remove(lastComma);
            errorText += "\n};";

            return errorText;

        }

        public JToken toUi(string url)
        {
            ErrorListDalJson errorListDalJson = new ErrorListDalJson();
            ErrorSynchronization errorSynchronization = new ErrorSynchronization();
            List<JToken> errorListApi = errorListDalJson.GetErrorListApi();
            JToken errorListUi = errorListDalJson.GetErrorListUI(url);
            JToken addedErrorList = errorSynchronization.AddErrorToJson(errorListApi, errorListUi);
            JToken finaleErrorListUi = errorSynchronization.RemoveErrorFromJson(errorListDalJson.GetErrorListApi(), addedErrorList);
            
            return finaleErrorListUi;
        }
    }
}