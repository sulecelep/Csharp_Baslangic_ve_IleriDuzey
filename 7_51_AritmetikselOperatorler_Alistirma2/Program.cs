using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_51_AritmetikselOperatorler_Alistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                1. sayıyı giriniz:
                2. sayıyı giriniz:

                +:
                -:
                /:
                *:
                %:
             
             */

            Console.WriteLine("1. sayıyı giriniz: ");
            double sayi1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            double toplam, fark, carpim, bolum, mod;
            toplam = sayi1 + sayi2;
            fark= sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            mod = sayi1 % sayi2;

            Console.WriteLine("+: " + toplam);
            Console.WriteLine("-: " + fark);
            Console.WriteLine("*: " + carpim);
            Console.WriteLine("/: " + bolum);
            Console.WriteLine("%: " + mod);
            Console.ReadLine();
        }
    }
}
