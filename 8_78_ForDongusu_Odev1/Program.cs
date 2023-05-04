using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_78_ForDongusu_Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kullanıcı bir sayı girişi yapsın, girilen sayının faktoriyelini alalım
            Console.WriteLine("Faktoriyelini bulmak istediğiniz bir sayı giriniz: ");
            int sayi=Convert.ToInt32(Console.ReadLine());

            var fakt = 1;
            for(int i = sayi; i>0; i--)
            {
                fakt *= i;
            }
            Console.WriteLine(sayi + " sayısının faktoriyeli: " + fakt);
            #endregion
        }
    }
}
