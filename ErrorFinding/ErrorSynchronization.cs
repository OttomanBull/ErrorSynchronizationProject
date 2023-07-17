using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorFinding
{

    public class ErrorSynchronization
    {
        ErrorListDal errorListDal = new ErrorListDal();

        public List<ErrorList> ErrorCodeComparison(List<ErrorList> list1, List<ErrorList> list2)
        {
            List<string> extendedErrorCodes1 = list1.Select(x => x.ExtendedErrorCode).ToList();
            List<string> extendedErrorCodes2 = list2.Select(x => x.ExtendedErrorCode).ToList();

            List<string> uniqueExtendedErrorCodes = extendedErrorCodes1.Except(extendedErrorCodes2).ToList();

            List<ErrorList> uniqueErrors = list1.Where(x => uniqueExtendedErrorCodes.Contains(x.ExtendedErrorCode)).ToList();

            return uniqueErrors;

        }
        public List<ErrorList> ErrorCodeUpate(List<ErrorList> list1, List<ErrorList> list2)
        {
            List<ErrorList> WillBeAddedUI = ErrorCodeComparison(list1, list2);
            List<ErrorList> ToBeRemovedUI = ErrorCodeComparison(list2, list1);

            List<ErrorList> UpdateList = new List<ErrorList>();
            UpdateList = list2;
            UpdateList.AddRange(WillBeAddedUI);

            foreach (var error in ToBeRemovedUI)
            {
                UpdateList.RemoveAll(e => e.ExtendedErrorCode == error.ExtendedErrorCode);
            }
            return UpdateList;

        }

        //burası uygulamada olmayacak, sadece yaptığımız şeyler fiziksel olarak gözüksün diye yaptım
        public void ShowUpdateUIErrorList()
        {
            List<ErrorList> WillBeAddedUI = ErrorCodeComparison(errorListDal.GetErrorListApi(), errorListDal.GetErrorListUI());
            List<ErrorList> ToBeRemovedUI = ErrorCodeComparison(errorListDal.GetErrorListUI(), errorListDal.GetErrorListApi());

            ErrorSynchronization errorSynchronization = new ErrorSynchronization();

            errorSynchronization.ErrorCodeUpate(errorListDal.GetErrorListApi(), errorListDal.GetErrorListUI());

            List<ErrorList> errorLists = new List<ErrorList>();
            errorLists = errorSynchronization.ErrorCodeUpate(errorListDal.GetErrorListApi(), errorListDal.GetErrorListUI());

            Console.WriteLine("Apide olup UI da olmayanlar");
            Console.WriteLine("");
            foreach (var item in WillBeAddedUI)
            {
                Console.WriteLine(item.ExtendedErrorCode);
                Console.WriteLine(item.DefaultDescription);
                Console.WriteLine("");
            }

            Console.WriteLine("UIda olup Apide olmayanlar");
            Console.WriteLine("");
            foreach (var item in WillBeAddedUI)
            {
                Console.WriteLine(item.ExtendedErrorCode);
                Console.WriteLine(item.DefaultDescription);
                Console.WriteLine("");
            }

            int AddedCount = WillBeAddedUI.Count;
            int RemovedCount = ToBeRemovedUI.Count;

            Console.WriteLine("UI a eklenecek kod sayısı= " + AddedCount);
            Console.WriteLine("UI dan silinecek kod sayısı= " + RemovedCount);

            Console.WriteLine(errorLists.Count());

            List <ErrorList> errorListUI = new List<ErrorList>();
            List<ErrorList> errorListApi = new List<ErrorList>();
            errorListUI = errorListDal.GetErrorListUI();
            errorListApi = errorListDal.GetErrorListApi();

            bool isEqual = errorListApi == errorLists;
            if (isEqual == true)
            {
                Console.WriteLine("Hata Kodları Eşitlendi");
            }
            else if (isEqual == false)
            {
                Console.WriteLine("Hata Koları eşitlenemedi");
            }
            else
            {
                Console.WriteLine("garip");
            };
            Console.ReadKey();
            
        }
       
    }
}
