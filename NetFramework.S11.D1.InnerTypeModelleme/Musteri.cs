using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeModelleme
{
    class Musteri
    {
        #region Fieldlar
        public int musteriId { get; set; }
        public string tckimlikno { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int kullanici_id { get; set; }
        public DateTime olusturma_tarih { get; set; }
        #endregion

        #region Inner Type'lar

        public MusteriAdres[] musteri_adresleri;
        public MusteriIletisim[] musteri_iletisim_bilgileri;
        public MusteriSiparis[] musteri_siparis_bilgileri;
        #endregion

        #region Constructor
        public Musteri()
        {
            musteri_adresleri = new MusteriAdres[5];
            musteri_iletisim_bilgileri = new MusteriIletisim[5];
            musteri_siparis_bilgileri = new MusteriSiparis[5];
        }
        #endregion



    }
}
