using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_66_KararYapilari_IF_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* if(şart / Şartlar || &&)
             * {
             *      Şart veya şartlar sağlanırsa yapılacak işlemler
             * }
            */

            Console.Write("Sayı 1 değerini giriniz: ");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Sayı 2 değerini giriniz: ");
            decimal sayi2= Convert.ToDecimal(Console.ReadLine());   

            decimal toplam= sayi1+ sayi2;
            //bool toplamKontrol = toplam > 50;

            //if(toplamKontrol)    //eğer doğruysa 
            //{
            //    Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den büyüktür.");
            //}

            if (toplam > 50)
            {
                Console.WriteLine("Girdiğiniz sayıların toplamı 50'den büyüktür.");
            }
            Console.ReadKey();  
        }
    }
}
