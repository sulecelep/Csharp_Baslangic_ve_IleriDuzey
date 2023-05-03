using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_72_KararYapilari_Alistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Menü
             * 1- Toplama
             * 2- Çıkarma
             * 3- Çarpma
             * 4- Bölme
             * 
             * Seçiniz:
             * 
             * Kurallar: 4. seçenek içerisinde bölen 0 olamaz kontrolü yapılacak
             */
            Console.WriteLine("Menü");
            Console.WriteLine("1- Toplama");
            Console.WriteLine("2- Çıkarma");
            Console.WriteLine("3- Çarpma");
            Console.WriteLine("4- Bölme");
            Console.WriteLine("Seçiniz: ");
            string secim= Console.ReadLine();

            Console.Clear();


            double sayi1 = 0;
            double sayi2 = 0;
            if( secim =="1"|| secim =="2" || secim=="3" || secim=="4")
            {
                Console.Write("1. sayıyı giriniz: ");
                 sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2. sayıyı giriniz: ");
                 sayi2 = Convert.ToDouble(Console.ReadLine());

            }
         
            if(secim =="1")
            {
                double toplam = sayi1 + sayi2;
                Console.WriteLine("Toplam: "+toplam);
            }
            else if (secim =="2")
            {
                double fark = sayi1 - sayi2;
                Console.WriteLine("Fark: " + fark);
            }
            else if (secim =="3")
            {
                double carpim= sayi1 * sayi2;
                Console.WriteLine("Çarpım: "+carpim);
            }
            else if (secim =="4")
            {
                if (sayi2 == 0)
                {
                    Console.WriteLine("Bölme işleminde payda 0 olamaz.");
                }
                else
                {
                    double bolme = sayi1 / sayi2;
                    Console.WriteLine("Bölme sonucu: " + bolme);
                }
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir işlem giriniz.");
            }

        }
    }
}
