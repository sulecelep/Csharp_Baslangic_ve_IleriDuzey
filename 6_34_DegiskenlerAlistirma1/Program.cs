using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_34_DegiskenlerAlistirma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");

            Console.WriteLine("İsminiz Nedir?");
            string isim=Console.ReadLine();

            Console.WriteLine("Soyisminiz Nedir?");
            string soyisim=Console.ReadLine();  

            Console.WriteLine("Yaşadığınız şehri giriniz: ");
            string sehir=Console.ReadLine();

            Console.Clear();

            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Soyisim: " + soyisim);
            Console.WriteLine("Şehir: " + sehir);
            Console.ReadLine();
        }
    }
}
