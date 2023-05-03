using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_71_KararYapilari_Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sistem içerisine giriş yapabilecek kullanıcı kodları
             * 
             * ABC - 123 - 236 - CMK
             * Kullanıcı girişiniz başarılı
             * 
             * Sistem içerisine girişi yasaklanmış kullanıcı kodları
             * 
             * HHH - BBB - MMM
             * Kullanıcı girişiniz kilitlenmiştir.
             * 
             * Bunların dışında ise,
             * 
             * Hatalı kullanıcı kodu girdiniz
             */


            Console.WriteLine("Kullanıcı Kodunu Giriniz: ");
            string kod=Console.ReadLine().ToUpper();


            //IF ELSE KULLANIMI
            if(kod=="ABC" || kod=="123" || kod=="236" || kod=="CMK")
            {
                Console.WriteLine("Kullanıcı girişiniz başarılı");
            }
            else if(kod=="HHH" || kod=="BBB" || kod=="MMM")
            {
                Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir");
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı kodu girdiniz.");
            }
            Console.ReadLine();


            //Switch kullanımı
            switch (kod)
            {
                case "ABC":
                case "123":
                case "236":
                case "CMK":
                    Console.WriteLine("Kullanıcı girişiniz başarılı");
                    break;
                case "HHH":
                case "BBB":
                case "MMM":
                    Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir.");
                    break;
                default:
                    Console.WriteLine("Hatalı kullanıcı kodu girdiniz.");
                    break;
            }
        }
    }
}
