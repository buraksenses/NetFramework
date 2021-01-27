using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
    public class BaseType
    {
        public int id { get; set; }
        public string ReferansKod { get; set; }
        public string tckimliknumara { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int Cinsiyet { get; set; }
        public DateTime kayitTarih { get; set; }
        public int kayitKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncellemeKullanici { get; set; }
        public bool silindi { get; set; }

        public BaseType()
        {
            Console.WriteLine("BaseType yapıcı metodu çalıştı...");
            IdAta();
        }

        private void IdAta()
        {
            Random rnd = new Random();
            this.id = rnd.Next(1000,9000);
        }

        public void BaseTest1()
        {
            Console.WriteLine("Test Metot 1 çalıştı...");
        }


        protected void BaseTest2()
        {
            Console.WriteLine("BaseTest2 metodu çağırıldı...");
        }
    }

}
