using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_118_Metot_Icinde_MetotTanimlama_LocalFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 7.0 ile gelen bir ozellik local functions
             * Metoda özel işlemleri metot içinde yazmaya yarar
             * Mesela toplama işlemini sadece bu metotta yapıp başka metotta kullanmayacaksak 
             * metodun içinde bir fonksiyon olarak tutabiliriz.
             */

            LocalFunctionKullanimi(12, 22);

        }
        static void LocalFunctionKullanimi(int sayi1, int sayi2)
        {
            int toplam=sayi1 + sayi2;
            int topla(int gelensayi1, int gelensayi2)
            {
                return gelensayi1+gelensayi2;
            } 
            int toplamDeger=topla(sayi1,sayi2);
            Console.WriteLine(toplamDeger);
        }
       
    }
}
