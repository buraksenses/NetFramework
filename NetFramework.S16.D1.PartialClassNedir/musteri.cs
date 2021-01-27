using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S16.D1.PartialClassNedir
{
    public class musteri
    {
        #region Field
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        #endregion


        #region Metot
        public int kayitDuzenle(musteri m)
        {
            Console.WriteLine("Kayıt düzenleme başarılı..");
            return 1;
        }

        public int kayitGuncelle(musteri m)
        {
            Console.WriteLine("Kayıt güncelleme başarılı..");
            return 1;
        }

        public int kayitSil(musteri m)
        {
            Console.WriteLine("Kayıt silme başarılı..");
            return 1;
        }
        #endregion

    }
}
