using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D1.OOPGiriş
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.maas = 5000;
            m1.isim = "Burak";
            m1.soy_isim = "Şenses";
            m1.yas = 20;

            Musteri m2 = new Musteri();
            m2 = m1;
            Console.WriteLine(m2.yas);
        }

        
    }
}
