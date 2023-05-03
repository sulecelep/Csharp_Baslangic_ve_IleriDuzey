using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_43_DegiskenlerAlistirma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soru 1: String olarak verilen değeri bool tipine dönüştürün
            string metin1 = "True";
            bool b2=bool.Parse(metin1);
            bool b1= Convert.ToBoolean(metin1);

            //Soru 2: int içerisinde olan 100 değerini byte ve float değişken tiplerine dönüştürün
            int s1 = 100;
            byte byteDegisken = (byte)s1;
            byte byteConv= Convert.ToByte(s1);
            float floatDegisken = s1;
            
            //Soru 3:Byte değişken içerisinde olan tipi Decimal değişken tipine dönüştürün
            byte byte1 = 10;
            decimal decimalConv = byte1;
        }
    }
}
