using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.HataYonetimi.TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            //merhabaHataYonetimi();
            hataYonetimiInceleme();
        }

        static void hataYonetimiInceleme()
        {
            try
            {
                //Standart uygulama için yazılan kod blokları
                Console.Write("Bir sayı giriniz:");
                int sayi1 = int.Parse(Console.ReadLine());

                if (sayi1 == 61)
                {
                    throw new OzelHataYonetimi();
                }
            }

            //catch(OzelHataYonetimi fx)
            //{
            //    Console.WriteLine("Özel hata sınıfı catch içerisinde yakalandı");
            //}

            catch(FormatException fx)//formatexception classı da exception classından türemiştir.
            {
                Console.WriteLine("Girdiğiniz değer sayısal bir değer olmalıdır!!");
                Console.WriteLine(fx.Message);
            }
            catch (Exception ex)//exception classı base classtır.
            {
                //Runtime hatalarının kullanıcıya daha açıklayıcı bir mesaj olarak gönderilmesine yarar.
                Console.WriteLine(ex.Message);
                
            }
            finally
            {
                //try => kod blokları çalışır
                //catch => hatayı yakalar, hata mesajı yollar
                //finally => hata olsa da olmasa da çalışır.Database erişim kapatma örneği!!
            }

        }

        static void merhabaHataYonetimi()
        {
            Console.Write("Bir sayı giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());
        }
    }
}
