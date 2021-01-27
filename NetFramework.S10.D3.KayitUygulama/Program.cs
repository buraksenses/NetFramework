using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D3.BolumSonuOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Musteri m1 = new Musteri();

            m1.ID = "12345";
            m1.isim = "Burak";
            m1.sifre = "Burack88";
            m1.soy_isim = "Şenses";
            m1.emailadres = "buraksenseees@gmail.com";
            m1._kullaniciadi = "buraksenseees";

            Musteri.musteriekle(m1);

            Musteri m2 = new Musteri();

            m2.ID = "11111";
            m2.isim = "Mustafa";
            m2.sifre = "Mustafa5561";
            m2.soy_isim = "Şenses";
            m2.emailadres = "mustafasenseees@gmail.com";
            m2._kullaniciadi = "mustafasenseees";

            Musteri.musteriekle(m2);

            Musteri m3 = new Musteri();

            m3.ID = "12345";
            m3.isim = "Burak";
            m3.sifre = "Burack88";
            m3.soy_isim = "Şenses";
            m3.emailadres = "buraksenseees@gmail.com";
            m3._kullaniciadi = "buraksenseees";

            Musteri.musteriekle(m3);



        }
    }
}
