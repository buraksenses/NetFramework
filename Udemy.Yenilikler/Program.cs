using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Yenilikler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region string interpolition

            //Eski kullanımlar...

            //string isim = "Burak";
            //string soyisim = "Şenses";

            //Console.WriteLine("Merhaba " + isim + " " + soyisim);//1.yol

            //string metin = string.Format("Merhaba {0} {1}",isim,soyisim);
            //Console.WriteLine(metin);

            //Console.WriteLine(string.Format("Merhaba {0} {1}", isim, soyisim));
            //Console.Clear();
            ////Yeni Kullanım...

            //Console.WriteLine($"Merhaba {isim} {soyisim}");

            #endregion

            #region var anahtar kelimesi

            //string name = "Burak";
            //Console.WriteLine(name);

            //var meslek = "PC Programmer";
            //var kategori = 12;
            //kategori = 3;

            #endregion

            #region İsimsiz Tip Kullanımı

            //İsimli tip...

            //musteri m = new musteri();
            //m.isim = "Burak";
            //m.soyisim = "Şenses";

            //İsimsiz tip...

            //var ogrenci = new
            //{
            //    numara = 510,
            //    isim = "Burak",
            //    soyisim = "Şenses"
            //};

            //musteri tipindeki m class örneğinin içerisindeki değerleri hem get hem de set edebildiğimiz halde isimsiz tipteki ogrenci örneğini
            //sadece get edebiliriz.Üzerinde oynama yapamayız!!!

            //ogrenci.isim = "Mustafa"; yazmaya kalktığımızda hata alırız!!

            #endregion

            #region Local Function

            //Normal metot 

            //Console.WriteLine(topla(12,34));//main metodunun dışında yazdığımız metodu çağırdık!

            //Local Function

            //int carp(int sayi1, int sayi2)
            //{
            //    return sayi1 * sayi2;
            //}

            //Console.WriteLine(carp(3,6));//Main metodunun içine yazdığımız local function ı çağırdık!!

            #endregion

            #region Metot parametrelerinde default değer ataması

            //int sonuc = carpma(12);
            //Console.WriteLine(sonuc);
            #endregion


            #region Try Catch When kullanımı

            //try
            //{
            //    // kod blokları...
            //    throw new FormatException("Format Hatası");
            //}
            //catch (FormatException fe) when (fe.Message == "Format Hatası")
            //{
            //    Console.WriteLine(fe.Message);
            //}
            //catch(FieldAccessException fex)
            //{
            //    Console.WriteLine(fex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
                
            //}

            #endregion




        }

        #region LocalFunction

        static int topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        #endregion

        #region Metotlarda default değer ataması

        //static int carpma(int sayi1,int sayi2 = 1)
        //{
        //    return sayi1 * sayi2;
        //}

        #endregion
    }
}
