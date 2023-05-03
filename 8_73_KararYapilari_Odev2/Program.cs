using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_73_KararYapilari_Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Not ortalaması sistemine hoş geldiniz!
             * 
             * İsim ve soyisim: Şule Celep
             * Not1:50
             * Not2: 40
             * Not3: 60
             * 
             * Ortalama 45 değerinden küçük ise: Kaldı
             * Ortalama 45 değerine eşit veya 70ten küçükse : Orta
             * Ortalama 70'e eşit veya 90'dan küçükse: İyi
             * Ortalama 90 ile 100 arasında ise: Pek İyi
             * Ortalama değeri 100'den büyükse: Notlarınızı kontrol ediniz.
             */

            Console.WriteLine("Not ortalaması sistemine hoş geldiniz! ");

            Console.WriteLine("\nİsim ve soyisim: ");
            string isimSoyisim=Console.ReadLine();

            Console.WriteLine("1. Not: ");
            double not1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2. Not: ");
            double not2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3. Not: ");
            double not3 = Convert.ToDouble(Console.ReadLine());

            double ortalama = (not1 + not2 + not3) / 3;

            if(ortalama < 45)
            {
                Console.WriteLine("Kaldı");
            }
            else if(ortalama>=45 && ortalama <70)
            {
                Console.WriteLine("Orta");
            }
            else if(ortalama>=70 && ortalama<90)
            {
                Console.WriteLine("İyi");
            }
            else if(ortalama>=90  && ortalama <=100)
            {
                Console.WriteLine("Pek İyi");
            }
            else
            {
                Console.WriteLine("Notlarınızı kontrol ediniz.");
            }

        }
    }
}
