using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D1.SanalMetotNedir
{
    class Musteri
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int MusteriId { get; set; }

        public override string ToString()
        {
            return isim + " " + soyisim;
        }
    }
}
