using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorFinding
{
    public class ToFolder
    {
        public void ToManagement()
        {
            ErrorListDal errorList = new ErrorListDal();
            List<ErrorList> listErrorManagement = errorList.GetErrorListManagement("https://raw.githubusercontent.com/xyztek/CrowdFundingManagement/master/src/lang/errorCodes/tr_TR.js");

            string errorText = "module.exports = { \n";
            
            foreach(ErrorList error in listErrorManagement)
            {
                errorText +=$"{ error.extendedErrorCode}: \"{error.defaultDescription}\",\n";
            }
            errorText += "};";
            Console.WriteLine(errorText);
        }
    }
}