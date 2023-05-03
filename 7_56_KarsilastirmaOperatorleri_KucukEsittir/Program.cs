using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_56_KarsilastirmaOperatorleri_KucukEsittir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = 100;
            int s2 = 150;

            // Küçük Eşit mi?
            // bool donenDeger = deg1 <= deg2 ;

            bool kucukEsitMi = s1 <= s2; 
            Console.WriteLine(kucukEsitMi);
        }
    }
}
