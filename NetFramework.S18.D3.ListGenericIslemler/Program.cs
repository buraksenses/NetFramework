using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D3.ListGenericIslemler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilarim = new List<int>();

            sayilarim.Add(1);

            int[] dizi = new int[4];

            for (int i = 0,j = 2; i < dizi.Length; i++,j++)
            {
                dizi[i] = j;
            }

            sayilarim.AddRange(dizi); // bir diziyi listenin içine ekleme...


            int capacity = sayilarim.Capacity;
            int count = sayilarim.Count;

            sayilarim.TrimExcess();//capacity ve count'u eşitler.

            capacity = sayilarim.Capacity;
            count = sayilarim.Count;

            sayilarim.ForEach(i => Console.WriteLine(i));//liste içerisindeki verileri ekrana yazar...

            bool kontrol1 = sayilarim.Any(i => i > 5);// içeride girilen şartı sağlayan bir değer varsa true döner.


            sayilarim.Sort();//alfabetik şekilde veya küçükten büyüğe sıralar.
            sayilarim.Reverse();//Tüm değerleri ters çevirir.

            sayilarim.Insert(2, 61);//Belirtilen indexe belirtilen değeri atar.


            int silinenAdet = sayilarim.RemoveAll(i => i < 3);//Belirtilen şartı sağlayan değerleri siler ve kaç değer sildiğini söyler.

            sayilarim.RemoveAt(3);//Belirtilen indexteki değeri siler.

            sayilarim.Clear();//Diziyi boşaltır.

        }
    }
}
