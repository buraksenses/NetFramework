using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D7.GenericClass
{
    public class genericRepository<T> where T:class
    {
        public genericRepository()
        {
            //context : EF DBFirst
        }

        public virtual List<T> Getir()
        {
            return null;
            //Gelen T tipini sorgulamak ve elde etmiş olduğum kayıtları generic koleksiyon olarak bir üst katmana dönmek...
        }


    }
}
