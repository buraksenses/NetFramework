using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D1.AbstractNedir
{
    public abstract class baseClass
    {
        public DateTime kayitTarih { get; set; }
        public DateTime guncellemeTarih { get; set; }

        public baseClass()// abstract classlar örneklenemez ancak bu classtan kalıtılan classlar örneklenirken bu sınıftan bir
            //örnek almak zorunda olduğu için, kalıtılan sınıf örneklendiğinde baseClassın yapıcı metodu çalışır.
        {
            kayitTarih = DateTime.Now;
            guncellemeTarih = DateTime.Now;
        }

        public void Test()
        {
            Console.WriteLine("Test metodu çalıştı...");
        }
        public abstract void Test2();// abstract metodun bodysini kalıtılan sınıflarda yazmamız gerekir.Hatta yazmak zorunludur.
        //Yazmazsak program hata verir.

    }
}
