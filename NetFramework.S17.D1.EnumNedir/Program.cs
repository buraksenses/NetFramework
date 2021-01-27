using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S17.D1.EnumNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();

            m1.id = 1;
            m1.isim = "Burak";
            m1.soyisim = "Şenses";
            m1.emailAdres = "buraksenseees@gmail.com";

            sanalDatabase sd = new sanalDatabase();

            musteriReturnValue musteriKayitSonuc = sd.musteriYeniKayit(m1);


            //if (musteriKayitSonuc == 717770001)
            //{

            //} 717770001 sayısı öylesine bir sayı ve projeyi başka bir yazılımcı ddevraldığında bunun ne olduğunu anlamayabilir.
            //Bu yüzden tam da burada enum devreye girer.

            if (musteriKayitSonuc == musteriReturnValue.kayitBasarili)
            {
                Console.WriteLine("Kayıt başarılı..");
            }

        }
    }
}
