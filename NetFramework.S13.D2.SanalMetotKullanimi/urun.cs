using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D2.SanalMetotKullanimi
{
    public class urun:baseClass
    {
        public override void ekranaYaz(string data)
        {
            Console.WriteLine("Urun => " + data);
        }
    }
}
