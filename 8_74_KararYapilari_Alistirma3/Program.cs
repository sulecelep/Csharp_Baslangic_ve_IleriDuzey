using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_74_KararYapilari_Alistirma3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kullanıcı Kodunu Giriniz: ");
            string kod = Console.ReadLine().ToUpper();

            switch (kod)
            {
                case "AA":
                case "BB":
                case "CC":
                    Console.WriteLine("Admin yetkisine sahipsiniz");
                    break;
                case "DD":
                    Console.WriteLine("Güçlü kullanıcı yetkisine sahipsiniz"); 
                    break;
                case "FF":
                case "EE":
                case "GG":
                    Console.WriteLine("Standart kullanıcı yetkisine sahipsiniz");
                    break;
                default:
                    Console.WriteLine("Hatalı kullanıcı kodu girdiniz.");
                    break;
            }
        }
    }
}
