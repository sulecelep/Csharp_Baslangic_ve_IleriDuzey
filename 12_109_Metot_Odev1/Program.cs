using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_109_Metot_Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Main metodundan bir öğrencinin Adını soyadını ve
            // 3 farklı ders notunu isteyeceğiz
            // bu bilgileri Ogrenci sınıfının içerisinde
            //OgrenciPuanHesapla adında bir metoda parametre olarak verip
            // Daha sonra bilgisini ekrana yazdıracaksınız
            //Şule Celep 1. notu 60 2. notu 3. notu ortalaması
            //eğer ortalaması 45 ten büyükse geçti küçükse kaldı
            Ogrenci ogr = new Ogrenci();
            Console.WriteLine("Adınız: ");
            string name=Console.ReadLine();
            Console.WriteLine("Soyadınız: ");
            string surname=Console.ReadLine();  
            Console.WriteLine("1. notunuz: ");
            decimal not1=Decimal.Parse(Console.ReadLine()); 
            Console.WriteLine("2. notunuz: ");
            decimal not2 = Decimal.Parse(Console.ReadLine());   
            Console.WriteLine("3. notunuz: ");
            decimal not3 = Decimal.Parse(Console.ReadLine());
            Console.Clear();

            decimal ortalama= ogr.OgrenciPuanHesapla(not1 ,not2,not3);

            ogr.OgrenciBilgileri(name, surname, not1, not2, not3, ortalama);
            ogr.GectiKaldi(ortalama);
            Console.ReadLine();
        }
    }
}
