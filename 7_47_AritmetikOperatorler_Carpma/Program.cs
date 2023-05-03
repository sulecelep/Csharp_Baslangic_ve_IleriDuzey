using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_47_AritmetikOperatorler_Carpma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte int double float decimal

            double d1 = 10.4;
            int d2 = 10;
            double sonuc = d1 * d2;
            int sonucInt = (int)(d1 * d2);
            sonucInt = (int)sonuc;
        }
    }
}
