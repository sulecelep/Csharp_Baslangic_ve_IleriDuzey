using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_57_Is_Operatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = 100;

            // is operatörü
            // bool donenDeger = degisken is degiskenTipi;
            object o1 = s1;
            Console.WriteLine(o1);

            s1 = (int)o1;
            //s1= (byte)o1;  //böyle olmadı is opr kllancaz

            bool isKontrol = o1 is int;
            Console.WriteLine(isKontrol);

            bool isKontrol1 = o1 is byte;
            Console.WriteLine(isKontrol1);
        }
    }
}
