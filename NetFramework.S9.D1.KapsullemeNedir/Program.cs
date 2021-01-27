using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D1.KapsullemeNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o1 = new Ogrenci();

            o1.Harclik = 25;

            Console.WriteLine(o1.Harclik);



            // 1.Değer okunsun ama değer ataması yapılamasın!!

            Ogrenci o2 = new Ogrenci();

            //o2.Numara = 25; The property or indexer 'Ogrenci.Numara' cannot be used in this context because the set accessor is inaccessible

            //Console.WriteLine("Id:" + o2.Numara.ToString());



            //2.Değer okunamasın, değer ataması yapılsın!!

            //Ogrenci o3 = new Ogrenci();

            //o3.Isim = "Mustafa";

            //Console.WriteLine("Isim:" + o3.Isim); Get inaccessible olduğu için hata verir ve değer okunamaz!!


            Ogrenci o4 = new Ogrenci();

            o4.isim = "Burak";
            o4.Soyisim = "senses";
            Console.WriteLine(o4.Soyisim);

        }
    }
}
