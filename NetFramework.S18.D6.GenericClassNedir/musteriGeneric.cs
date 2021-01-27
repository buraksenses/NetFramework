using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D6.GenericClassNedir
{
    public class musteriGeneric<T>
    {

        public T id { get; set; }//Bu kullanım tercih edilmez.Çünkü id değişkeninin başka bir veri tipinde olması mümkün değildir.
        public T musteriNumara { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string Tckimlik { get; set; }
        public DateTime dogumTarih { get; set; }

        public T musteriNoAl ()
        {
            return musteriNumara;
        }

    }
}
