using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D2.AracClassOdev
{
    class Arac
    {
        internal string marka;
        internal string model;
        internal string yakit_tipi;
        internal string vites_tipi;

        public int model_yil;
        
        public float km;       
        internal int alis_fiyat;
        private int satis_fiyat;
        private int max_indirim;
        private int Fiyat;

        Arac() { }

        Arac(string markasi,string modeli) { marka = markasi;model = modeli; }

        public Arac(string markasi,string modeli,int model_yili) { marka = markasi; model = modeli; model_yil = model_yili; }

        internal Arac(string markasi,string modeli,int model_yili,int kilometre) { 
            marka = markasi;
            model = modeli;
            model_yil = model_yili;
            km = kilometre;
        }
        
        internal void showInfos()
        {
            Console.WriteLine("Marka:{0}",marka);
            Console.WriteLine("Model:{0}", model);
            Console.WriteLine("Model Yili:{0}", model_yil);
            Console.WriteLine("Yakit tipi:{0}", yakit_tipi);
            Console.WriteLine("Vites tipi:{0}", vites_tipi);
            Console.WriteLine("Km:{0}", km);
            Console.WriteLine("Fiyat:{0}", Fiyat);
        }

        internal void fiyatAta(int fiyat) 
        {
            if (fiyat >= 100000)
            {
                Random r = new Random();
                int oran = r.Next(1, 10);

                max_indirim = fiyat / oran;

                fiyat = fiyat - max_indirim;
                Fiyat = fiyat;
                Console.WriteLine("Son Fiyat: {0}",Fiyat);
            }
            else
            {
                Random r1 = new Random();
                int oran1 = r1.Next(1, 5);

                max_indirim = fiyat / oran1;
                fiyat = fiyat - max_indirim;
                Fiyat = fiyat;
                Console.WriteLine("Son Fiyat: {0}", Fiyat);
            }
            
        
        }

    }
}
