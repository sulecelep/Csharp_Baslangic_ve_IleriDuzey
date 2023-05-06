using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_89_DoWhile_Odev2Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ödev 1 : Kullanıcıdan 1-X arasında bir sayı girmesini isteyin.Daha sonra sistem 
            //kullanıcınn girmiş olduğu 1 ile X değerleri arasında bir sayı tahmini yapsın. Daha sonra
            //kullanıcı sistemin ürettiği sayıyı bulmaya çalışsın, bulamazsa yeniden sorsun
            //ne zaman kullanıcı bulursa Y kadar denediniz ve sonuca ulaştınız?

            int tahmin = 0;
            int uretilenSayi = 0;
            int sayac = 0;
            Console.Write("Tahmin oyunu için en yüksek değeri giriniz: ");
            int kullaniciMaxVal=Convert.ToInt32(Console.ReadLine());    

            Random rnd = new Random();  
            uretilenSayi=rnd.Next(1,kullaniciMaxVal);

            do
            {
                sayac++;
                Console.WriteLine("{0}. hakkınız üretilen sayıyı tahmin ediniz ",sayac);
                tahmin=Convert.ToInt32(Console.ReadLine());

            } while(tahmin!=uretilenSayi);
            Console.WriteLine("Tebrikler {0} kere tahmin ettikten sonra buldunuz!",sayac);
        }
    }
}
