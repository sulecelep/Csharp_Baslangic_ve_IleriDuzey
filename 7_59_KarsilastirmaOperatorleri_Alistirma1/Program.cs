using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_59_KarsilastirmaOperatorleri_Alistirma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Kullanıcıdan gelen 3 farklı sınav notunun ortalaması 
             * 45 değerine eşit veya büyük mü kontrol edelim.
             */

            Console.WriteLine("1. sınav notunu giriniz: ");
            double not1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sınav notunu giriniz: ");
            double not2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3. sınav notunu giriniz: ");
            double not3 = Convert.ToInt32(Console.ReadLine());

            double ortalama;
            ortalama = (not1 + not2 + not3)/3;

            bool isKontrol = ortalama >= 45;


            Console.WriteLine(isKontrol + " "+ ortalama);

        }
    }
}
