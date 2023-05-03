using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_37_BilincsizTurDonusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bilinçsiz Tür dönüşümü

            int sayi1 = 256;
            int intMin = int.MinValue;
            int intMax = int.MaxValue;
            byte sayi2 = (byte)sayi1; //içindeki değere ben kefilim diyoruz
            //uygulama bizim sözümüze güveniyor istersek 300 de yazabilirz hata vermeyecek gibi
            //görünür ama default olarak 0 kabul eder.
            //Buna bilinçsiz tür dönüşümü denilir.


        }
    }
}
