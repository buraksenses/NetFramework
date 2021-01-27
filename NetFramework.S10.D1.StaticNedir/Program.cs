using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D1.StaticNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o1;
            Ogrenci.Test1();

            o1 = new Ogrenci();
            o1.Test2();
        }
    }
}
