using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeModelleme
{
    class MusteriSiparis
    {
        public string Siparis_Id { get; set; }

        public Urun[] UrunBilgileri;

        public MusteriSiparis()
        {
            UrunBilgileri = new Urun[5];
        }
    }
}
