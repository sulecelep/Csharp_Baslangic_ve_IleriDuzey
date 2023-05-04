using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_83_WhileDongusu_GenelKullanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While Döngüsü
            /*
            while(true) //şart doğru olduğu sürece çalışmaya devam eder
            {
                
                    1- While(False)
                    2- Break;
                 
            }
        */
            //ÖRNEK: Ekrana 1-10'a kadar sayıların değerini yazdırlaım
            int sayac = 1;
            while(sayac<=10)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
        }
    }
}
