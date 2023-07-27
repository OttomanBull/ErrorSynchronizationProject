using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace ErrorFinding
{
    public class ToFolder
    {
        /*public void ToManagementFile()
        {
            ErrorListDalCollections errorList = new ErrorListDalCollections();
            ErrorSynchronization errorSynchronization = new ErrorSynchronization();
            List<ErrorList> listErrorManagement = errorSynchronization.compareErrorsVElif(errorList.GetErrorListApi(),errorList.GetErrorListManagement("https://raw.githubusercontent.com/xyztek/CrowdFundingManagement/master/src/lang/errorCodes/tr_TR.js"));

            string managementFolder = @"C:/Users/Elif Aslan/Desktop/error/management.js";
            string errorText = "module.exports = { \n";

            foreach(ErrorList error in listErrorManagement)
            {
                errorText +=$"{ error.extendedErrorCode}: \"{error.defaultDescription}\",\n";
            }
            errorText += "};";
            Console.WriteLine(errorText);

            if (File.Exists(managementFolder))
            {
                File.Delete(managementFolder);
            }

            using (FileStream fs = File.Create(managementFolder))
            {
                Byte[] content = new UTF8Encoding(true).GetBytes(errorText);
                fs.Write(content, 0, content.Length);
            }
        }*/

        /*public void ToUiFile()
        {
            ErrorSynchronization errorSynchronization = new ErrorSynchronization();
            ErrorListDalJson errorListDalJson = new ErrorListDalJson();
            string uiFolder = @"C:/Users/Work and Study/Desktop/errorui.json";

            JArray errors = errorSynchronization.ErrorCodeUpateVBahadir((JArray)errorListDalJson.GetErrorListApiJson(), (JArray)errorListDalJson.GetErrorListUIJson());
            JArray json = (JArray)JsonConvert.SerializeObject(errors, Formatting.Indented);
            //json formatına çevirme

            if (File.Exists(uiFolder))
            {
                File.Delete(uiFolder);
            }

            using (FileStream fs = File.Create(uiFolder))
            {
                Byte[] content = new UTF8Encoding(true).GetBytes((string)json);
                fs.Write(content, 0, content.Length);
            }
        }*/
    }
}