using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D2.KapsullemeAraOdev
{
    class Musteri
    {
        private string  tckimliknumarasi;

        public string _tckimliknumarasi
        {
            set
            {
                bool bayrak = true;

                while (bayrak)
                {
                    bayrak = false;
                    if (value.Length == 11)
                    {

                        for (int i = 0; i < value.Length; i++)
                        {
                            bool kontrol = char.IsNumber(value[i]);
                            if (kontrol)
                            {
                                //do nothing...
                            }
                            else
                            {
                                Console.Write("Lütfen 11 haneli bir numara giriniz!!");
                                value = Console.ReadLine();
                                bayrak = true;
                            }
                        }
                    }
                    else
                    {
                        Console.Write("Lutfen 11 basamaklı bir sayı giriniz:");
                        value = Console.ReadLine();
                        bayrak = true;
                    }
                }
                this.tckimliknumarasi = value;
               
            }

            get
            {
                return this.tckimliknumarasi.Substring(0,3);
            }
        }
    }
}
