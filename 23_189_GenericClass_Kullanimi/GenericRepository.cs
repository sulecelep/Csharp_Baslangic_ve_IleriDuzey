using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_189_GenericClass_Kullanimi
{
	public class GenericRepository<T> //where T : class sadece classlar T tipi olabilir
	{
        public GenericRepository()
        {
            //context : EF DBFirst

        }

        public virtual List<T> Getir()
        {
            // Gelen T tipini database üzerinden sorgulamak ve elde etmiş
            //olduğum kayıtları generic koleksiyon olaran bir üst katmana dönmek

            return null;
        }
        public virtual void yeniKayitEkle(T data)
        {
            //bize gelen T tipi içerisindeki bilgiyi T tipinin işaret etmiş olduğu
            //tabloya ekliyoruz
        }
    }
}
