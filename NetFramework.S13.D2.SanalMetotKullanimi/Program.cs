using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D2.SanalMetotKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            televizyon t1 = new televizyon();
            t1.ekranaYaz("Hangisi? ");

            //Urun sınıfı içerisinde override edilen metot çalışır çünkü televizyon sınıfı ürün sınıfından kalıtıldığı için
            //ürün sınıfı içerisinde override edilen metot önceliklidir ve base classa gitmesini engeller.

            urun u1 = new urun();
            u1.ekranaYaz("Merhaba");

            baseClass b1 = new baseClass();
            b1.ekranaYaz("Merhaba");
        }
    }
}
