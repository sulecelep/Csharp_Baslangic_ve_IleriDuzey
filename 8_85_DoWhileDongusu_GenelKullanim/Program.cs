using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_85_WhileDongusu_Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sistemin çalışma zamanında oluşturduğu 1 ile 10 arasındaki bir değeri
            //kullanıcının tahmin etmesini isteyecek bir uygulama

            int uretSayi = 0;
            Random random = new Random();
            //random.Next(1,10); //Çalışırken üreteceği min ve max değerleri istiyor 
            uretSayi= random.Next(1,10);

            int sayac=0;
            while (true)
            {
                Console.WriteLine("Tahmininiz nedir?");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (tahmin != uretSayi)
                {
                    sayac++;
                    Console.WriteLine("{0}. denemeniz, tahmin edemediniz lütfen tekrar deneyin..\n",sayac);
                    continue;
                }

                if (tahmin == uretSayi)
                {
                    sayac++;
                    Console.WriteLine("Tebrikler {0}. denemede bildiniz!", sayac);
                    break;

                }

            }
        }
    }
}
