using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D2.ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();

            a1.Add(10);
            a1.Add("on");

            for (int i = 0; i < a1.Count; i++)
            {
                Console.WriteLine(a1[i]);
            }
            
            //ArrayList'in generic versiyonu
            List<int> a2 = new List<int>();

            a2.Add(12);
            //a2.Add("on iki");  Hata verir çünkü Arraylisti sadece int değer kabul edecek şekilde ayarladım.


            for (int i = 0; i < a2.Count; i++)
            {
                Console.WriteLine(a2[i]);
            }


            //User-defined veriyi generic liste aktarma...
            musteri musteri1 = new musteri();
            musteri1.id = 5;
            musteri1.isim = "Burak";
            musteri1.soyisim = "Şenses";

            List<musteri> m1 = new List<musteri>();

            m1.Add(musteri1);
            

            foreach (musteri item in m1)
            {
                Console.WriteLine(item.isim);
            }
            
        }
    }
}
