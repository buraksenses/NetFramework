using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D1.KapsullemeNedir
{
    class Ogrenci
    {

        internal string isim;
        private string soy_isim;
        private string emailadres;

        public string Soyisim
        {
            get
            {
                return this.soy_isim;
            }
            set
            {
                this.soy_isim = value;
                this.emailadres = string.Format("{0}.{1}@gmail.com", isim, soy_isim);
            }
        }


        #region Değer okunamasın,değer atansın

        //public Ogrenci()
        //{
        //    isim = "Burak";
        //}

        //public string Isim
        //{
        //    private get
        //    {
        //        return this.isim;
        //    }
        //    set
        //    {
        //        this.isim = value;
        //    }
        //}



        #endregion


        #region Değer okunsun,değer atanamasın

        private int numara;

        //public Ogrenci()
        //{
        //    numara = numaraUret();
        //}

        //public int Numara
        //{
        //    get
        //    {
        //        return this.numara;
        //    }

        //    private set
        //    {
        //        this.numara = value;
        //    }
        //}

        //private int numaraUret()
        //{
        //    Random rnd = new Random();
        //    return rnd.Next(1, 100);
        //}
        #endregion


        #region Değer okunsun, değer atansın
        private int harclik;

        public int Harclik
        {
            set
            {
                this.harclik = value;
            }

            get
            {
                return this.harclik;
            }

        }
        #endregion

    }
}
