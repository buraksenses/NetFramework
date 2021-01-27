using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S19.D2.KullaniciGirisUygulamasi
{
    public class sanalDatabase
    {
        public static List<kullanici> kullaniciTablo = new List<kullanici>();

        static sanalDatabase()
        {
            kullaniciTablo.Add(new kullanici()
            {
                id = 1,
                isim = "Burak",
                soyisim = "Şenses",
                kullaniciAdi = "buraksenseees",
                sifre = "Burack88",
                aciklama = "Burak Şenses kullanıcı profili"
            });

            kullaniciTablo.Add(new kullanici()
            {
                id = 2,
                isim = "Mustafa",
                soyisim = "Şenses",
                kullaniciAdi = "mustafasenseees",
                sifre = "Mustafa5561",
                aciklama = "Mustafa Şenses kullanıcı profili"
            });
        }

    }
}
