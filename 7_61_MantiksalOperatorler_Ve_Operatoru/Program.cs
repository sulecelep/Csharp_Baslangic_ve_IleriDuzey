using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_61_MantiksalOperatorler_Ve_Operatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ve  operatörü &&
            // bool donenDeger = deg1=="admin" && deg2 == "123";  TRUE

            /*
                Degisken1  Degisken2  Sonuc
                True       True        True
                False      True        False
                True       False       False
                False      False       False

             */

            string kullaniciAdi = "admin";
            string sifre = "123";

            bool donenDeger= kullaniciAdi =="admin" && sifre == "123";  

            Console.WriteLine(donenDeger);

        }
    }
}
