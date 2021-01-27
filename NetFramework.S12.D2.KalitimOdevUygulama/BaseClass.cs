using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D2.KalitimOdevUygulama
{
    public class BaseClass
    {
        static int i = 1;
        private int _id;

        public int id
        {
            get
            {
                return _id;
            }
            private set
            {

            }
        }
        private string _barkod;
        public string barkod
        {
            get
            {
                return _barkod;
            }
            set
            {
                bool kontrol = sanalDatabase.Kontrol(value);
                if (!kontrol)
                {
                    this._barkod = value;
                }
            }
        } 




        public DateTime olusturma_tarih { get; set; }
        public int olusturan_kullanici { get; set; }

        public DateTime guncelleme_tarih { get; set; }
        public int guncelleyen_kullanici { get; set; }
        public bool silindi { get; set; }



        public BaseClass()
        {
            for (int j = i + 1; i < j; i++)
            {
                this._id = i;
            }
        }
    }
}
