using System.Text;

namespace ErrorFinding
{
    public class ToFolder
    {
        public void ToManagementFile()
        {
            ErrorListDal errorList = new ErrorListDal();
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

        }

        public void ToUiFile()
        {
            string uiFolder = @"C:/Users/Elif Aslan/Desktop/error/ui.json";


            //json formatına çevirme

            /*
             * 
             * 
             * */


            if (File.Exists(uiFolder))
            {
                File.Delete(uiFolder);
            }

            using (FileStream fs = File.Create(uiFolder))
            {
                /*
                 * 
                 * 
                 * */
            }


        }


    }
}