using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeModelleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();

            m1.musteriId = 12345;
            m1.kullanici_id = 1;
            m1.olusturma_tarih = DateTime.Today;
            m1.isim = "Burak";
            m1.soyisim = "Şenses";
            m1.tckimlikno = "65325469875";

            m1.musteri_adresleri[0] = new MusteriAdres 
            {
                Il ="Trabzon",
                Ilce = "Ortahisar",
                Adres = "Tepekent sitesi",
                Adres_Tip = "Ev"
            };

            m1.musteri_iletisim_bilgileri[0] = new MusteriIletisim
            {
                tel_no = "5306600253",
                AktifPasif = true
            };

            m1.musteri_siparis_bilgileri[0] = new MusteriSiparis
            {
                Siparis_Id = "1000"
                
            };

            m1.musteri_siparis_bilgileri[0].UrunBilgileri[0] = new Urun
            {
                fiyat = 5000,
                urun_Id = 5,
                Tanim = "Ayakkabı"
                
            };
            m1.musteri_siparis_bilgileri[0].UrunBilgileri[0].Test();
        }
    }
}
