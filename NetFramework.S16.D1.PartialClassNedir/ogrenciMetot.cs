using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S16.D1.PartialClassNedir
{
    class ogrenci
    {
        public int yeniKayit(ogrenci o)
        {
            Console.WriteLine("Kayıt düzenleme başarılı..");
            return 1;
        }

        public int kayitGuncelle(ogrenci o)
        {
            Console.WriteLine("Kayıt güncelleme başarılı..");
            return 1;
        }

        public int kayitSil(ogrenci o)
        {
            Console.WriteLine("Kayıt silme başarılı..");
            return 1;
        }
    }
}
