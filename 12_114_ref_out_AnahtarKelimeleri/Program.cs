using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_114_ref_out_AnahtarKelimeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Paramertelerin Ram'da durmalarını inceleyeceğiz


            /*
             * Ref ve Out anahtar sözcüklerinde eski .net framework versiyonlarında
             * bir fark vardı. 7.0 olanlar bu farktan etkilenmeyecektir.
             * 7.0 ref ya da out değer alsa da almasa da kullandırttırabiliyor.
             */

            /*
             * Ram'da Stack ve Heap bölgesi vardır, Heap'te sadece referanstipli değişkenler saklanır
             * değer tipli bir değişken olan sayi1 ref tipli değişken olarak bir metoda atandığında
             * artık metottaki değişkenle aynı nesneye bakacak metottaki değişken değişirse
             * o da aynı nesneye baktığı için o da değişecek.
             */

            int sayi1 = 0;
            int sayi2; //out kullanırsak sayi2'ye değer vermediğimiz için hata alacaktık. 
            //ref ile out arasındaki fark bu
            degerAta(ref sayi1);
        }

        static void degerAta(ref int gelenDeger)
        {
            gelenDeger = 10;
        }
    }
}
