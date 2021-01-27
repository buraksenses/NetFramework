using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
    public class Egitmen:BaseType
    {
        public string Brans { get; set; }
        public int BransSeviye { get; set; }

        public DateTime IsBaslangicTarih { get; set; }
        public DateTime IsBitisTarih { get; set; }
        public int IzinGunSayisi { get; set; }


        public Egitmen()
        {
            Console.WriteLine("Eğitmen yapıcı metodu çalıştı...");
        }

        
    }
}
