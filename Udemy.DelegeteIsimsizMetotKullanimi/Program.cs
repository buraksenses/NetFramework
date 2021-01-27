using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.DelegeteIsimsizMetotKullanimi
{
    class Program
    {
        //Delegate oluşturma
        delegate void printScreen(string isim, string soyisim);

        static void Main(string[] args)
        {
            printScreen testMetot1 = new printScreen(test1);//Var olan metodu çağırma

            printScreen testMetot2 = new printScreen(delegate (string isim, string soyisim) //Isimsiz metot kullanımı
            {

                Console.WriteLine(isim + " " + soyisim);
            
            });

            printScreen testMetot3 = (string isim, string soyisim) =>//Lambda expression kullanımı
            {
                Console.WriteLine(isim + " " + soyisim);
            };

        }

        static void test1(string isim, string soyisim)
        {
            Console.WriteLine(isim + " " + soyisim);
        }
    }
}
