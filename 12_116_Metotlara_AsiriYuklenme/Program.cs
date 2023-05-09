using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_116_Metotlara_AsiriYuklenme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Metotlara Aşırı Yüklenme (OVERLOAD)

            /*
             * 
             * 
             */

            Console.WriteLine("Merhaba Dünya");
            topla("Şule", " Celep"); //3. overloadı kullandım
        }

        static void topla(int sayi1 , int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }
        static void topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }
        static void topla(string metin1, string metin2)
        {
            string toplam= metin1 + metin2;
            Console.WriteLine(toplam);
        }
    }
}
