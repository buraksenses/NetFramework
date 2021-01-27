using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
    public class Personel:BaseType
    {
        public DateTime IsBaslangicTarih { get; set; }
        public DateTime IsBitisTarih { get; set; }
        public int IzinGunSayisi { get; set; }

        public Personel()
        {
            Console.WriteLine("Personel yapıcı metodu çalıştı...");
            //BaseTest2();
        }

        
        
    }
}
