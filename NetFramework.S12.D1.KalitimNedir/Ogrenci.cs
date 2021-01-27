using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
    public sealed class Ogrenci:Personel // Ogrenci sınıfı hiçbir sınıftan kalıtılamaz çünkü sealed anahtar kelimesi ile mühürlendi!!!
    {
        public int seviye { get; set; }
        public string bolum { get; set; }

        public Ogrenci()
        {
            Console.WriteLine("Öğrenci yapıcı metodu çalıştı...");
            //BaseTest2();   BaseType sınıfı içinde protected olarak oluşturulan metodu, BaseType sınıfından türediği için
            //Ogrenci sınıfında da çağırabildik.
        }

        
    }
}
