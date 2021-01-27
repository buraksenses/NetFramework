using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.PersonelIslemleri
{
    class Personel
    {
        public static string Emailadres = "firmam.com";


        public string Isim
        {
            get;
            set;           
        }

        public string Soyisim { get; set; }

        private string _emailadres;

        public string emailadres
        {
            get
            {
                return this._emailadres;
            }
            set
            {
                this._emailadres = value.ToLower() + "@" + Personel.Emailadres;
            }
        }
    }
}
