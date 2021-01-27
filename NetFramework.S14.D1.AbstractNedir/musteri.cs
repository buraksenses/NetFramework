using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D1.AbstractNedir
{
    internal class musteri:baseClass
    {
        public int musteriID { get; set; }

        public musteri()
        {
            Console.WriteLine("müsteri yapıcı metodu");
        }

        public override void Test2()
        {
            Console.WriteLine("musteri => Test2");
        }
    }
}
