using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_42_DegiskenAlistirmalar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *Merhaba
             *İsminiz:Şule
             *Soyisim:Celep
             *Şehir:İstanbul
             *Yaş:28
             *
             *Ekran temizle
             *Çıktı
             */

            Console.WriteLine("Merhaba");
            Console.WriteLine("İsminiz: ");
            string isim=Console.ReadLine();

            Console.WriteLine("Soyisim: ");
            string soyisim=Console.ReadLine();

            Console.WriteLine("Şehir: ");
            string sehir=Console.ReadLine();

            Console.WriteLine("Yaş: ");
            int yasConvert= Convert.ToInt32(Console.ReadLine());
            int yasParse = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("İsim: "+isim);
            Console.WriteLine("Soyisim: " + soyisim);
            Console.WriteLine("Şehir: " + sehir);
            Console.WriteLine("Yaş: " + yasConvert);

            Console.ReadLine();
        }
    }
}
