using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D2.KapsullemeAraOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();

            m1._tckimliknumarasi = "31169356554";
            Console.WriteLine(m1._tckimliknumarasi);
            
        }
    }
}
