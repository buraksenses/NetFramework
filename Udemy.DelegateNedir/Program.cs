using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.DelegateNedir
{
    class Program
    {
        delegate void MatematikselIslemler(int sayi1, int sayi2);
        static void Main(string[] args)
        {
            //Topla(10, 20);
            //Cikar(20, 10);
            //Carp(2, 5);

            MatematikselIslemler m1 = new MatematikselIslemler(Topla);//Delegate içinde sadece topla metodu var şu an.
            
            m1 += Cikar;//delegate içine çıkar metodunu da eklemiş olduk.
            m1 += Carp;//aynı şekilde carp metodunu da eklemiş olduk.
            m1.Invoke(30,2);//delegate içindeki metodları verilen değerlere göre sırasıyla çalıştırır.

            Delegate[] islemlistesi = m1.GetInvocationList();

            foreach (var item in islemlistesi)
            {
                Console.WriteLine(item.Method.Name);//sırasıyla invoke edilen metotları yazdırır.
            }

            m1 -= Cikar;//bu işlem de delegate içinden bu metodu çıkarır.
            m1 -= Carp;//şu anda delegate içinde yalnızca topla metodu var.

        }

        static void Topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplama işleminin sonucu: {0}",sonuc);
        }

        static void Cikar(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Çıkrama işleminin sonucu: {0}", sonuc);
        }

        static void Carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("TÇarpma işleminin sonucu: {0}", sonuc);
        }

    }
}
