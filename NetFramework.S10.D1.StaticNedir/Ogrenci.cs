using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D1.StaticNedir
{
    class Ogrenci
    {
        public string isim { get; set; }
        public string soyisim { get; set; }

        public static void Test1()
        {
            Console.WriteLine("nesne örneği alınmadan çalışan metot!!");
        }

        internal void Test2()
        {
            Console.WriteLine("nesne örneği alındıktan sonra çalışan metot!!");
        }
    }
}
