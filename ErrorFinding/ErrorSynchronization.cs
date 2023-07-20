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
        public ErrorSynchronization()
        {
            Test = 5;

            errorListDal = new ErrorListDal();
        }

        // field member
        private ErrorListDal errorListDal = new ErrorListDal();

        // property member
        protected int Test { get; }

        // method member
        public IEnumerable<ErrorList> ErrorCodeComparison(IEnumerable<ErrorList> compareSource, IEnumerable<ErrorList> compareAgainst)
        {
            return compareSource.ExceptBy(compareAgainst.Select(i => i.ExtendedErrorCode), errorList => errorList.ExtendedErrorCode);
        }

        public List<ErrorList> ErrorCodeUpate(IEnumerable<ErrorList> list1, IEnumerable<ErrorList> list2)
        {
            var willBeAddedUI = ErrorCodeComparison(list1, list2).ToList();
            var ToBeRemovedUI = ErrorCodeComparison(list2, list1).ToList();

            //var updateList = new List<ErrorList>();
            List<ErrorList> updateList = list2.ToList();

            updateList.AddRange(willBeAddedUI);

            foreach (var error in ToBeRemovedUI)
            {
                updateList.RemoveAll(e => e.ExtendedErrorCode == error.ExtendedErrorCode);
            }

            return updateList;

        }

        public void SaveToDesktop(IEnumerable<ErrorList> list1)
        {
            string targetDirectory = @"C:\Users\Work and Study\Desktop";

            // Dosya yolunu oluşturun
            string filePath = Path.Combine(targetDirectory, "update_list.txt");

            // Dönüştürülecek listeyi JSON formatına çevirme
            string json = JsonSerializer.Serialize(list1, new JsonSerializerOptions { WriteIndented = true });

            // JSON verisini dosyaya yazma
            File.WriteAllText(filePath, json);

            Console.WriteLine("JSON verisi masaüstünde update_list.txt dosyasına kaydedildi.");
        }

        //burası uygulamada olmayacak, sadece yaptığımız şeyler fiziksel olarak gözüksün diye yaptım
        public void ShowUpdateUIErrorList()
        {
            IEnumerable<ErrorList> WillBeAddedUI = ErrorCodeComparison(errorListDal.GetErrorListApi(), errorListDal.GetErrorListUI());
            IEnumerable<ErrorList> ToBeRemovedUI = ErrorCodeComparison(errorListDal.GetErrorListUI(), errorListDal.GetErrorListApi());

            ErrorSynchronization errorSynchronization = new ErrorSynchronization();

            errorSynchronization.ErrorCodeUpate(errorListDal.GetErrorListApi(), errorListDal.GetErrorListUI());

            IEnumerable<ErrorList> errorLists = new List<ErrorList>();
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

            int AddedCount = WillBeAddedUI.Count();
            int RemovedCount = ToBeRemovedUI.Count();

            Console.WriteLine("UI a eklenecek kod sayısı= " + AddedCount);
            Console.WriteLine("UI dan silinecek kod sayısı= " + RemovedCount);

            Console.WriteLine(errorLists.Count());

            List<ErrorList> errorListUI = new List<ErrorList>();
            List<ErrorList> errorListApi = new List<ErrorList>();
            errorListUI = errorListDal.GetErrorListUI();
            errorListApi = errorListDal.GetErrorListApi();

            bool isEqual = true;

            if (errorListApi == errorLists)
            {
                isEqual = true;
            }
            else
            {
                if (errorLists.Count() != errorListApi.Count())
                {
                    isEqual = false;
                }
                else
                {
                    isEqual = errorListApi.All(apiError => errorLists.Contains(apiError));
                }
            }

            Console.WriteLine
            (
                isEqual
                    ? "Hata Kodları Eşitlendi"
                    : "Hata Koları eşitlenemedi"
            );
            Console.ReadKey();

        }

        internal List<ErrorList> compareErrorsListVElif(List<ErrorList> errorLists1, List<ErrorList> errorLists2)
        {
            throw new NotImplementedException();
        }
    }
}
