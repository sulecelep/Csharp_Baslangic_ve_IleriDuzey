using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_49_ModAlma_Azaltma_Arttırma_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mod alma operatörü %
            int s1 = 10;
            int s2 = 2;
            int sonucMod = s1 % s2;

            // ++ operatörü
            int s3 = 10;
            int OperatorSonucI = s3++; // önce değeri atar sonra toplama işlemi yapar
            int OperatorSonucII = ++s3; //toplama işlemi yaptıktan sonra değeri atar
            int OperatorSonucIII = (s3++); //yine s3++ ile aynı işi yapıyor

            //-- operatörü

            int s4 = 10;
            int OptSonuc1 = s4--;
            int OptSonuc2 = --s4;

        }
    }
}
