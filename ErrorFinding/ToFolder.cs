using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace ErrorFinding
{
    public class ToFolder
    {
        public string ManagementFileProcces(string url)
        {
            ErrorListDalJson errorListDalJson = new ErrorListDalJson();
            ErrorSynchronization errorSynchronization = new ErrorSynchronization();
            JToken listErrorManagement = errorSynchronization.RemoveErrorFromJson(errorListDalJson.GetErrorListApi(), errorListDalJson.GetErrorListManagement(url));
            JToken errorListToCompare = listErrorManagement.SelectToken("errorCodes");

            string errorText = "module.exports = { \n";

            foreach (var error in errorListToCompare)
            {
                JProperty errorProp= error as JProperty;
                errorText += $"{errorProp.Name}: \"{errorProp.Value.ToString()}\",\n";
            }
            int lastComma= errorText.LastIndexOf(',');
            errorText=errorText.Remove(lastComma);
            errorText += "\n};";

            return errorText;

        }

        public JToken UIFileProcces(string url)
        {
            ErrorListDalJson errorListDalJson = new ErrorListDalJson();
            ErrorSynchronization errorSynchronization = new ErrorSynchronization();
            List<JToken> errorListApi = errorListDalJson.GetErrorListApi();
            JToken errorListUi = errorListDalJson.GetErrorListUI(url);
            JToken addedErrorList = errorSynchronization.AddErrorToJson(errorListApi, errorListUi);
            JToken finaleErrorListUi = errorSynchronization.RemoveErrorFromJson(errorListDalJson.GetErrorListApi(), addedErrorList);
            
            return finaleErrorListUi;
        }

        public void ChangeUIFile()
        {
            JToken uiJson = UIFileProcces("https://raw.githubusercontent.com/OttomanBull/ErrorSynchronizationProject/Bahad%C4%B1r/ErrorFinding/ErrorLists/UIEn.json");
            string filePathUI = @"C:\Users\Work and Study\Documents\GitHub\ErrorSynchronizationProject\ErrorFinding\ErrorLists\UIEn.json";
            ClearFile(filePathUI);
            WriteListToJsonFile(filePathUI, uiJson);

        }

        public void ChangeManagementFile()
        {
            string managementText = ManagementFileProcces("https://raw.githubusercontent.com/OttomanBull/ErrorSynchronizationProject/Bahad%C4%B1r/ErrorFinding/ErrorLists/ManEn.js");
            string filePathMan = @"C:\Users\Work and Study\Documents\GitHub\ErrorSynchronizationProject\ErrorFinding\ErrorLists\ManEn.js";
            ClearFile(filePathMan);
            WriteDataToJSFile(filePathMan, managementText);
        }



        static void ClearFile(string filePath)
        {
            File.WriteAllText(filePath, string.Empty);
        }

        static void WriteListToJsonFile(string filePath, JToken dataList)
        {
            string json = JsonConvert.SerializeObject(dataList, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        static void WriteDataToJSFile(string filePath, string jsData)
        {
            File.WriteAllText(filePath, jsData);
            Console.WriteLine("");
        }
    }
}