using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D1.SanalMetotNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();

            m1.isim = "Burak";
            m1.soyisim = "Şenses";

            Console.WriteLine(m1.ToString()); 
            
        }
    }
}
