using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D2.KalitimOdevUygulama
{
    public class Urun : BaseClass
    {
        public string marka { get; set; } // * yalnızca veritabanında bulunan markaların satışı yapılabilir
        public string model { get; set; }

        private decimal AlisFiyat;
        public decimal alis_fiyat
        {
            get
            {
                return AlisFiyat;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Alış fiyatı 0 dan küçük veya 0 a eşit olamaz!!");
                }
                else
                {
                    this.AlisFiyat = value;
                }
            }
        } // * 0 dan küçük olamaz

        private decimal SatisFiyat;
        public decimal satis_fiyat
        {
            get
            {
                return SatisFiyat;
            }
            set
            {
                if (value <= AlisFiyat)
                {
                    Console.WriteLine("Satış fiyatı alış fiyatından küçük olamaz!!");
                }
                else
                {
                    this.SatisFiyat = value;
                }
            }
        } // * alış fiyatından küçük olamaz

        private decimal KampanyaFiyat;
        public decimal kampanya_fiyat
        {
            get
            {
                return KampanyaFiyat;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Kampanya fiyatı 0 dan küçük veya 0 a eşit olamaz!!");
                }
                else
                {
                    this.KampanyaFiyat = value;
                }
            }
        } // * 0 dan küçük olamaz

    }
}
