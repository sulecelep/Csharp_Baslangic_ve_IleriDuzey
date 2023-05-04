using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_79_ForDongusu_BreakContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sonsuz Döngü Oluşturmak
            int sayac = 0;

            for ( ; ; )
            {
                //break ve continue
                sayac++;
                if (sayac == 2)
                    // break; //kod for'dan çıkar
                    continue;  //2'ye gelince kodu yapmadan tekrar for'a geri dönecek ve devam edecek
                Console.WriteLine(sayac);

                Console.WriteLine("Ben sonsuz döngüyüm"); 
            }
        }
    }
}
