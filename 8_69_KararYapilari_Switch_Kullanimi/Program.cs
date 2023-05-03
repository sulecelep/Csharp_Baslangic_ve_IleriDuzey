using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_69_KararYapilari_Switch_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * switch(ifade)
             * {
             * case kontrol1 :
             * {
             * çalışacak olan işlemler 
             * break;
             * }
             * case kontrol2 : 
             * {
             * çalışacak işlemler
             * break;
             * }
             * default:
             * {
             * çalışacak olan işlemler
             * }
             * }
             * 
             */

            Console.Write("Hangi Ay: ");
            string kullaniciGelen=Console.ReadLine();

            switch(kullaniciGelen)
            {
                case "Ocak":           //burada ocak veya Şubat gelirse 02 yazacak
                case "Şubat":
                    Console.WriteLine("02");
                    break;
                case "Mart":
                    Console.WriteLine("03");
                    break;
                case "Nisan":
                    Console.WriteLine("04");
                    break;
                case "Mayıs":
                    Console.WriteLine("05");
                    break;
                case "Haziran":
                    Console.WriteLine("06");
                    break;
                case "Temmuz":
                    Console.WriteLine("07");
                    break;
                case "Ağustos":
                    Console.WriteLine("08");
                    break;
                case "Eylül":
                    Console.WriteLine("09");
                    break;
                case "Ekim":
                    Console.WriteLine("10");
                    break;
                case "Kasım":
                    Console.WriteLine("11");
                    break;
                case "Aralık":
                    Console.WriteLine("12");
                    break;
                default:
                    Console.WriteLine("Geçersiz ay adı girdiniz.");
                    break;
            }
            Console.WriteLine("Kod1");
        }
    }
}
