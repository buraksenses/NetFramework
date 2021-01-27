using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D1.InterfaceNedir
{
    public class Musteri : IMusteri
    {
        string _isim;
        string _soyisim;
        int _id;

        public string isim { get { return _isim; } set { _isim = value; } }
        public string soyisim { get { return _soyisim; } set { _soyisim = value; } }
        public int Id { get { return _id; } set { _id = value; } }

        public int kayitDuzenle()
        {
            Console.WriteLine("Kayıt düzenlendi..");
            return 1;
        }

        public int kayitGuncelle()
        {
            Console.WriteLine("Kayıt güncellendi..");
            return 1;
        }

        public int kayitSil()
        {
            Console.WriteLine("Kayıt silindi..");
            return 1;
        }
    }
}
