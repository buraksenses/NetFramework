using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1.Udemy.RSSOkumaUygulaması
{
    public class Haber
    {
        public string baslik { get; set; }
        public string yorum { get; set; }
        public string aciklama { get; set; }

        public override string ToString()
        {
            return baslik;
        }
    }
}
