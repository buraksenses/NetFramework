using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeModelleme
{
    class Urun
    {
        public string Tanim { get; set; }
        public int urun_Id { get; set; }
        public decimal fiyat { get; set; }

        public Urun()
        {
            Console.WriteLine("Urun constructor called!!");
        }

        public void Test()
        {
            Console.WriteLine("Test metodu çağırıldı.");
        }

    }
}
