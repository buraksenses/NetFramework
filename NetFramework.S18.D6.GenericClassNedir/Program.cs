using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D6.GenericClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {

            //Normal class tanımı...

            musteri m1 = new musteri();

            m1.dogumTarih = DateTime.Parse("05.10.1999");
            m1.id = 1;
            m1.isim = "Burak";
            m1.soyisim = "Şenses";
            m1.Tckimlik = "15489654835";
            m1.musteriNumara = "1221";


            //Generic class tanımı

            musteriGeneric<int> generic1 = new musteriGeneric<int>();

            generic1.id = 1;
            generic1.musteriNumara = 9876;

        }
    }
}
