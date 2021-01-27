using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S10.D3.BolumSonuOdev
{
    class Musteri
    {
        public static ArrayList A1;

        public string ID { get; set; }
        public string isim { get; set; }
        public string soy_isim { get; set; }
        private string KullaniciAdi { get; set; }
        public string sifre { get; set; }

        private string Emailadres { get; set; }
        public string emailadres
        {
            get
            {
                return this.Emailadres;
            }

            set
            {
                bool b2 = EmailKontrol(value);

                if (b2)
                {
                    Console.WriteLine("Email adresi zaten sisteme kayıtlı!!");
                    Emailadres = string.Empty;

                }
                else
                {
                    Emailadres = value;
                }
            }
        }


        static Musteri()
        {
            A1 = new ArrayList();
        }

       


        public string _kullaniciadi
        {
            get
            {
                return KullaniciAdi;
            }
            set
            {
                bool b1 = Kontrol(value);

                if (b1)
                {
                    Console.WriteLine("Kullanıcı adı zaten sisteme kayıtlı!!");
                    KullaniciAdi = string.Empty;
                }
                else
                {
                    KullaniciAdi = value;
                }
                
                
            }
        }

        static bool Kontrol(string kullaniciadi)
        {
            bool kontrol = false;

            for (int i = 0; i < A1.Count; i++)
            {
                Musteri Temp = (Musteri)A1[i];

                if (Temp.KullaniciAdi == kullaniciadi)
                {
                    kontrol = true;
                    break;
                }
            }
            return kontrol;
                    
        }

        static bool EmailKontrol(string emailadres)
        {
            bool kontrol = false;

            for (int i = 0; i < A1.Count; i++)
            {
                Musteri temp = (Musteri)A1[i];

                if (temp.Emailadres == emailadres)
                {
                    kontrol = true;
                    break;
                }
            }
            return kontrol;
        }
        


        public static void musteriekle(Musteri m1) 
        {
            
            
            if (m1 != null && !string.IsNullOrEmpty(m1.KullaniciAdi))
            {
                if (m1.Emailadres == string.Empty)
                {
                    Console.WriteLine("Girmiş olduğunuz e-mail adresi sistemde kayıtlıdır!!");
                }
                else
                {
                    A1.Add(m1);
                    Console.WriteLine("Sisteme başarıyla kaydoldunuz!!");
                }
            }
            else
            {
                Console.WriteLine("Bir hata oluştu!!");
            }
            Console.Clear();
         
        }
        
    }
}
