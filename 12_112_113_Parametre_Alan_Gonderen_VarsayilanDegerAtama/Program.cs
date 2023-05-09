using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_112_113_Parametre_Alan_Gonderen_VarsayilanDegerAtama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            Console.WriteLine("Adınız: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınız: ");
            string surname = Console.ReadLine();
            Console.WriteLine("1. notunuz: ");
            decimal not1 = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("2. notunuz: ");
            decimal not2 = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("3. notunuz: ");
            decimal not3 = Decimal.Parse(Console.ReadLine());
            Console.Clear();

            decimal ortalama = ogr.OgrenciPuanHesapla(not1, not2, not3);

            ogr.OgrenciBilgileri(name, surname, not1, not2, not3, ortalama);
            ogr.GectiKaldi(ortalama);
            Console.ReadLine();
        }
    }
}
