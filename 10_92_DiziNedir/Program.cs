using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_92_DiziNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi Nedir?
            string[] ogrenciListesi = new string[5];

            //Diziye değer ekleme
            // 0 1 2 3 4  indexler
            ogrenciListesi[0] = "Şule Celep";
            ogrenciListesi[1] = "Cengiz Atilla";
            ogrenciListesi[2] = "Zeynep Bostan";
            ogrenciListesi[3] = "Miray Durgun";
            ogrenciListesi[4] = "Sena Boyuktaş";


            //Console.WriteLine(ogrenciListesi[1]);

            foreach (var item in ogrenciListesi)
            {
                Console.WriteLine(item);
            }
            Console.Clear();

            for (int i = 0; i < ogrenciListesi.Length; i++)
            {
                string gelenIsim = ogrenciListesi[i];
                Console.WriteLine(gelenIsim);
            }
        }
    }
}
