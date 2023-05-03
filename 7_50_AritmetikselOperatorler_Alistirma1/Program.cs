using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_50_AritmetikselOperatorler_Alistirma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Merhaba,
             * İsminiz:
             * Soyisminiz:
             * Doğum Yılınız:
             * 
             * Ekranı Temizle
             * 
             * Merhaba Şule Celep 29 yaşındasınız...
             * 
             */

            Console.WriteLine("Merhaba ");
            Console.Write("İsminiz: ");
            string isim=Console.ReadLine();

            Console.Write("Soyisminiz: ");
            string soyisim = Console.ReadLine();

            Console.Write("Doğum Yılınız: ");
            int dogumYili = Convert.ToInt32(Console.ReadLine());
            int yas = DateTime.Now.Year - dogumYili;
            Console.Clear();

            Console.WriteLine("Merhaba "+isim+" "+soyisim+ " "
                + yas+ " yaşındasınız...");
            Console.ReadLine();
        }
    }
}
