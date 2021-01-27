using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S12.D2.KalitimOdevUygulama
{
    public static class sanalDatabase
    {
        private static ArrayList db = new ArrayList();

        public static void yeniUrunEkle(BaseClass data)
        {
            if (data != null && string.IsNullOrEmpty(data.barkod))
            {
                db.Add(data);
            }
        }

        public static bool Kontrol(string barkod)
        {
            bool kontrol = false;

            for (int i = 0; i < db.Count; i++)
            {
                if (db.Contains(barkod))
                {
                    kontrol = true;
                }
            }


            return kontrol;
        }

    }
}
