using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S17.D1.EnumNedir
{
    public class sanalDatabase
    {
        ArrayList SD = new ArrayList();

        public musteriReturnValue musteriYeniKayit(musteri m1)
        {
            SD.Add(m1);
            //return 717770001;
            return musteriReturnValue.kayitBasarili;
        }

    }
}
