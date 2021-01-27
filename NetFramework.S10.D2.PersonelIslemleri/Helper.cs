using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.PersonelIslemleri
{
    internal static class Helper
    {
        public static void EmailGonder(string Email,string konu,string icerik) 
        {
            //Mail işlemleri yapılıyor...
            Console.WriteLine("Mail başarıyla gönderildi!!");
        }

        //1.static classlar örneklenemez!!
        //Helper h1 = new Helper(); yazdığımızda hata verir.

        //2.static classlar içlerinde static olmayan metot veya field barındıramaz.
        //public void Test()
        //{

        //}
        //Yazdığımızda program hata verir.
        //public string isim; adında static olmayan bir değişken tanımlamak istediğimizde de hata verir.

        //3.Ancak static classlar içerisinde static constructorlar kullanabiliriz.
        //Static yapıcı metotlar program içerisinde kaç kere çağırıldıklarına bakmaksızın yalnızca ilk çağrıldıkları zaman
        //çalışırlar.

        static Helper()
        {
            Console.WriteLine("Constructor called!!");
        }

    }
}
