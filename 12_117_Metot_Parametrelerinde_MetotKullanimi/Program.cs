using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_117_Metot_Parametrelerinde_MetotKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Metot Parametrelerinde metot kullanma

            decimal toplam = topla(12M, 23M);
            EkrandaGoster(toplam);  //uzun gösterim

            EkrandaGoster(topla("Şule", "Celep")); //kısa gösterim
        }

        static void EkrandaGoster(object o)
        {
            Console.WriteLine(o.ToString());
        }
        static int topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
        static decimal topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            return toplam;
        }
        static string topla(string metin1, string metin2)
        {
            return metin1 + " " + metin2;
        }
    }
}
