using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_68_KararYapilari_IF_ELSE_IF_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
          * if(şartlar)
          * {
          *     Şartlar sağlanıyorsa çalışacak kodlar
          * }
          * else if(şartlar)
          * {
          *      Şartlar sağlanıyorsa çalışacak kodlar
          * }
          * else
          * {
          *       Şartlar sağlanmıyorsa çalışacak kodlar
          * }
          * 
          */

            Console.Write("Sayı 1 değerini giriniz: ");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Sayı 2 değerini giriniz: ");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

            decimal toplam = sayi1 + sayi2;

            if(toplam>=100)
            {
                Console.WriteLine("Girilen değer 100'e eşit veya büyüktür.");
            }
            else if(toplam>=50)
            {
                Console.WriteLine("Girilen değer 50'ye eşit veya büyüktür.");

            }
            else
            {
                Console.WriteLine("Girilen değer 50'den küçüktür.");

            }
        }
    }
}
