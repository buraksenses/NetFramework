using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S19.D6.FormKontrolleriInceleme
{
    public class sanalDatabase
    {

        public static List<musteri> musteriler;

        static sanalDatabase()
        {
            musteriler = new List<musteri>();
        }
    }
}
