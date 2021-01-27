using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D5.DictionaryListVeSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h1 = new Hashtable();

            h1.Add(1, "bir");
            h1.Add(2, "iki");
            //h1.Add(1, "üç"); Key değeri benzersiz olmalıdır.Aksi halde hata verir.

            Dictionary<int, string> DictList = new Dictionary<int, string>();

            DictList.Add(1, "Bir");
            DictList.Add(2, "İki");
            DictList.Add(3, "Üç");

            bool kontrol =  DictList.Remove(3);

            if (kontrol)
            {
                Console.WriteLine("Silindi...");
            }
            else
            {
                Console.WriteLine("Silinemedi...");
            }



            if (DictList.Remove(20))
            {
                Console.WriteLine("Değer silindi...");
            }
            else
            {
                Console.WriteLine("Değer bulunamadı...");
            }


            bool arananDeger =  DictList.ContainsKey(2);//Girilen değerde bir anahtar olup olmadığını sorgular.

            if (arananDeger)
            {
                Console.WriteLine("Değer bulundu...");
            }
            else
            {
                Console.WriteLine("değer bulunamadı...");
            }

            foreach (KeyValuePair<int,string> item in DictList)
            {
                Console.WriteLine("Anahatar : {0} || Değer : {1}",item.Key,item.Value);
            }



            //********** SORTEDLIST ******* //Dictionary'den tek farkı girilen key değerlerine göre sıralaması!!


            SortedList<int, string> sortList = new SortedList<int, string>();

            sortList.Add(1, "bir");
            sortList.Add(23, "yirmi üç");
            sortList.Add(6, "altı");
            sortList.Add(1000, "bin");

            foreach (KeyValuePair<int,string> item in sortList)
            {
                Console.WriteLine("Anahtar : {0} || Değer : {1}",item.Key,item.Value);
            }


        }
    }
}
