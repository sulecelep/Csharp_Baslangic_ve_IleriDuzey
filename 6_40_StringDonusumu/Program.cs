using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_40_StringDonusumu_Convert_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin1 = "100";
            int s1 = int.Parse(metin1);
            int s2 = Convert.ToInt32(metin1);

            string metin2 = "True";
            bool b1= bool.Parse(metin2);
            bool b2= Convert.ToBoolean(metin2);

            string metin3 = null;
            decimal d1=decimal.Parse(metin3); //null olamaz hatası aldık
            decimal d2=Convert.ToDecimal(metin3); //hata almadık default değeri yazdı
            bool b3=Convert.ToBoolean(metin3); 
        }
    }
}
