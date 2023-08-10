using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace ErrorFinding
{
    public class ToFolder
    {
        public static string ManagementFileProcces(string filePath)
        {
            ErrorListDalJson errorListDalJson = new ErrorListDalJson();
            ErrorSynchronization errorSynchronization = new ErrorSynchronization();
            JToken listErrorManagement = ErrorSynchronization.RemoveErrorFromJson(ErrorListDalJson.GetErrorListApi(), ErrorListDalJson.GetErrorListManagement(filePath));
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

        public static JToken UIFileProcces(string filePath)
        {
            ErrorListDalJson errorListDalJson = new ErrorListDalJson();
            ErrorSynchronization errorSynchronization = new ErrorSynchronization();
            List<JToken> errorListApi = ErrorListDalJson.GetErrorListApi();
            JToken errorListUi = ErrorListDalJson.GetErrorListUI(filePath);
            JToken addedErrorList = ErrorSynchronization.AddErrorToJson(errorListApi, errorListUi);
            JToken finaleErrorListUi = ErrorSynchronization.RemoveErrorFromJson(ErrorListDalJson.GetErrorListApi(), addedErrorList);
            
            return finaleErrorListUi;
        }

        public static void ChangeUIFile()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appSettings.json", false, true).Build();
            JToken uiJson = UIFileProcces(configuration.GetSection(@"ErrorDirectory:UIDirectoryEn").Value);
            string filePathUI = configuration.GetSection(@"ErrorDirectory:UIDirectoryEn").Value;
            ClearFile(filePathUI);
            WriteListToJsonFile(filePathUI, uiJson);
            Console.WriteLine("Error List Eşitleme İşlemi Yapılıyor");

        }

        public static void ChangeManagementFile()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appSettings.json", false, true).Build();
            string managementText = ManagementFileProcces(configuration.GetSection(@"ErrorDirectory:ManagamentDirectoryEn").Value);
            string filePathMan = configuration.GetSection(@"ErrorDirectory:ManagamentDirectoryEn").Value;
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