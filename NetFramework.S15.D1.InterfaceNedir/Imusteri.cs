using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D1.InterfaceNedir
{
    public interface IMusteri
    {

        //public Imusteri()
        //{

        //}Interfaceler yapıcı metot barındırmazlar.Sadece şablon işlevi görürler.

        string isim { get; set; }
        string soyisim { get; set; }
        int Id { get; set; }

        int kayitDuzenle();
        int kayitSil();
        int kayitGuncelle();
    }
}
