using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D2.AracClassOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Arac a1 = new Arac("Mercedes Benz","CL65 AMG",2010,50000);

            a1.fiyatAta(183000);

            a1.showInfos();

            Console.ReadLine();

        }
    }
}
