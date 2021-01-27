using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.PersonelIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel();

            p1.Isim = "Burak";
            p1.Soyisim = "Senses";
            p1.emailadres = "Buraksenseees";

            Helper.EmailGonder(Personel.Emailadres, "Yeni personel bilgilendirme", p1.Isim + p1.Soyisim);
            Helper.EmailGonder(Personel.Emailadres, "Yeni personel bilgilendirme", p1.Isim + p1.Soyisim);

        }
    }
}
