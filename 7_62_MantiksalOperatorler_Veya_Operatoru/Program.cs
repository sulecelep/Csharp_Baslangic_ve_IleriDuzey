using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_62_MantiksalOperatorler_Veya_Operatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Veya  operatörü ||
            // bool donenDeger = deg1=="admin" || deg2 == "123";  TRUE

            /*
                Degisken1  Degisken2  Sonuc
                True       True        True
                False      True        True
                True       False       True
                False      False       False

             */

            string anahtar = "AAAA";
            bool geriDonus = anahtar == "ABCD" || anahtar == "AAAA" || anahtar == "BBBB";
            Console.WriteLine(geriDonus);
        }
    }
}
