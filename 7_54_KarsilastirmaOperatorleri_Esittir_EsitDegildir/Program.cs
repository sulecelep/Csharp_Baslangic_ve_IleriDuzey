using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_54_KarsilastirmaOperatorleri_Esittir_EsitDegildir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = 100;
            int s2 = 100;

            //Atama operatorü =
            //Degisken = AtanacakDeger

            //Eşit mi?  ==

            bool esitMi = s1 == s2;
            bool farkliMi = s1 != s2;
            Console.WriteLine(esitMi);
            Console.WriteLine(farkliMi);

        }
    }
}
