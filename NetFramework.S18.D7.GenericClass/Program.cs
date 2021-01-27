using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D7.GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            genericRepository<musteri> musteriRepository = new genericRepository<musteri>();
            //musteri tipini aldı ve içerisindeki yapıcı metottaki işlemler çalıştı.
            List<musteri> musterilerim =  musteriRepository.Getir();
            //musteri classı içerisindeki datayı database e gönderdi.


            genericRepository<Urun> urunRepository = new genericRepository<Urun>();
            //urun tipini aldı ve içerisindeki yapıcı metottaki işlemler çalıştı.
            List<Urun> Urunlerim =  urunRepository.Getir();
            //urun classı içerisindeki datayı database e gönderdi.


            //Sonuç olarak her iki class için de aynı işlemleri yapabileceğimiz tek bir generic class kullanarak verimliliği 
            //arttırdık ve her class için ayrı bir operasyonel işlem yapmamıza gerek kalmadı.C++ daki Template'ler gibi...

        }
    }
}
