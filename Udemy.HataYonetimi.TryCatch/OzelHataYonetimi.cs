using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.HataYonetimi.TryCatch
{
    public class OzelHataYonetimi:Exception
    {
        public OzelHataYonetimi()
        {
            Console.WriteLine("Özel hata yönetimi çalıştı");
        }
    }
}
