using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_82_ForeachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Foreach döngüsü 
            //bir veri kümesindeki verileri taramak istediğimzde kullanırız


            //Genel Kullanımı
            string [] Isimler = new [] { "Şule Celep", "Berkay Celep", "Simay Celep", "Baran Celep", "Yahya Celep" };
            foreach(var item in Isimler)
            {
                Console.WriteLine(item);
            }


        }
    }
}
