using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_107_YeniMetotTanimlamak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Selamla();
            Ogrenci ogr = new Ogrenci(); //nesne oluşturduk
            //ogr.SelamlaOgrenci();  //Ogrenci sınıfındaki SelamlaOgrenci metoduna gittik 
            ogr.OgrenciMetot1("Şule","Celep");
            ogr.OgrenciMetot2();
        }
        static void Selamla()
        {
            Console.WriteLine("Selamlar");
        }
    }
}
