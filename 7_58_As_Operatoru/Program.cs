using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_58_As_Operatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //as operatörü

            string isimSoyisim = " ŞuleCelep";
            object objStr = isimSoyisim; // kutulama
            string sonucStr= objStr as string;  
           
            // içindeki değer eğer string ise bunu bir başka
            //string değişkenine de ata
        }
    }
}
