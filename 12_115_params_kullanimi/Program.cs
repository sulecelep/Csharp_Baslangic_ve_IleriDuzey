using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_115_params_kullanimi
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            /*
             * Params: girilen değerleri belirmiş olduğumuz veri tipinden diziye çevirir.
             * bunu parametre olarak isterken bizden bir dizi istemez, belirtmiş olduğumuz
             * veri tipinden sıralı data ister. İstemiş olduğu sıralı datayı da diziye otomatik olarak aktarır.
             * 
             * DİKKAT: params parametreler içinde son parametre olmalıdır, params'dan sonra 
             * parametre yazılmaz 
             * 
             * string name'i o yüzden ilk parametre olarak kullandık
             */

            topla("Şule",5, 9, 20, 45, 11, 22, 56);
            
        }

        static void topla(string name, params int[] sayilar)
        {
            int toplam = 0;
            for(int i=0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine("Toplam: {0}",toplam);
        }

    }
}
