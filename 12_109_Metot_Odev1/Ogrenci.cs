using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_109_Metot_Odev1
{
    public class Ogrenci
    {
        public decimal OgrenciPuanHesapla(decimal not1, decimal not2, decimal not3)
        {
            decimal ortalama = (not1+not2+not3) / 3;
            return ortalama;
        }

        public void OgrenciBilgileri(string name, string surname,decimal not1, decimal not2, decimal not3, decimal ortalama)
        {
            Console.WriteLine("Öğrencinin Adı: {0} ",name);
            Console.WriteLine("Öğrencinin Soyadı: {0} ",surname);
            Console.WriteLine("1. Notu: {0} ",not1);
            Console.WriteLine("2. Notu: {0} ",not2);
            Console.WriteLine("3. Notu: {0} ",not3);
            Console.WriteLine("Ortalaması: {0} ",ortalama);

        }

        public void GectiKaldi( decimal ortalama)
        {
            if(ortalama >= 45)
            {
                Console.WriteLine("Geçti");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }
        }
    }

}
