using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIO.DirectoryIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ödev1
            //if (!Directory.Exists("d:\\Udemy"))
            //{
            //    Console.WriteLine("Klasör bulunamadı.Yeni klasör oluşturuluyor...");
            //    System.Threading.Thread.Sleep(2000);
            //    YeniKlasorOlustur("d:\\Udemy");
            //    Console.WriteLine("Klasör oluşturuldu!!");
            //}

            //else
            //{
            //    Console.WriteLine("Aynı isimde bir klasör bulunuyor.Silip yeni bir tane oluşturmak ister misiniz?E/H");
            //    string kullaniciTercih = Console.ReadLine();
            //    switch (kullaniciTercih)
            //    {
            //        case "E":
            //            klasorSilme("d:\\Udemy");
            //            Console.WriteLine("Klasör başarıyla silindi!!");
            //            YeniKlasorOlustur("d:\\Udemy");
            //            Console.WriteLine("Yeni klasör oluşturuldu!!");
            //            break;
            //        case "H":
            //            break;


            //        default:
            //            break;
            //    }



            //}
            #endregion

            klasorTasi("d:\\Udemy", "d:\\Games\\Annen");

        }

        static void YeniKlasorOlustur(string path)
        {
            DirectoryInfo d1 =  Directory.CreateDirectory(path);
        }

        static void VarlikKontrolu(string path)
        {
            bool kontrol = Directory.Exists(path); //Klasörün o dizinde bulunup bulunmadığını kontrol eder.
            
        }

        static void klasorSilme(string path)
        {
            //Directory.Delete(path); Klasörün içi boşsa sorunsuz çalışır.Doluysa hata verir!!!!

            Directory.Delete(path, true); // Klasör dolu da olsa boş da olsa içindekilerle beraber siler.
        }

        static void klasorTasi(string kaynak,string hedef)
        {
            Directory.Move(kaynak, hedef);
        }

    }
}
