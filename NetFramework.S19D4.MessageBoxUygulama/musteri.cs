using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S19D4.MessageBoxUygulama
{
    public class musteri
    {
        public Guid id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        public string telefonNo { get; set; }

        public override string ToString()
        {
            return isim + " " + soyisim;
        }
    }
}
