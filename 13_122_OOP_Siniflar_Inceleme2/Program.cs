using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_122_OOP_Siniflar_Inceleme2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Garbage Collector 
             * kullanılmayan atıl kalan nesneleri ram'den temizler
             * 
             * M1 ve M2 aynı nesneye bakıyordu fakat ikisini null yapınca
             * artık Müşteri nesnesine bakan olmadığı için Heap bölgesindeki 
             * nesne kümesi Garbage Collectore atılır yani çöpe atılır ve 
             * Ram rahatlar bunu Using ile nasıl tutacağımızı sonraki bölümlerde anlatacak.
             */
            Musteri M1 = new Musteri();
            M1.TCKimliknumara = "12546532615";
            M1.isim = "Şule";
            M1.soyisim = "Celep";
            M1.cinsiyet = 717770002;

            Musteri M2 = M1;
            M2.isim = "Zülbiye";
            M2.TCKimliknumara = "12546378965";

            M2 = null;
            M1 = null;
            string isim = M2.isim;
        }
    }
}
