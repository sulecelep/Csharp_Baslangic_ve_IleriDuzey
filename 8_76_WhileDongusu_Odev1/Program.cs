using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_84_WhileDongusu_Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan gelen sayısal değere göre ekrana 1 eksilterek 0'a ulaşıncaya kadar ekrana yazdıralım

            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            while (sayi >= 0)
            {
                Console.WriteLine(sayi);
                sayi--;
            }
            Console.Clear();

            //Kullanıcıdan gelen değerlerin toplamını ekrana yazdıralım
            //0'dan kucuk bir değer girişi yapılırsa toplama işlemini bitirelim
            //ve ekrana toplam sonucunu yazalım
            Console.WriteLine("Lütfen toplamak istediğiniz sayıları giriniz.");
            Console.WriteLine("-1 değeri işlemi durdurur");

            int toplam = 0;
            
            while(true) //sonsuz döngü oluşturup çıkacağımız noktayı kendimiz belirledik
            {
                string sayiStr = Console.ReadLine();
                int sayiInt= int.Parse(sayiStr);

                if (sayiInt < 0)
                    break;
                else
                    toplam += sayiInt;

            }
            Console.WriteLine("Toplam değer: {0}",toplam);
        }
    }
}
