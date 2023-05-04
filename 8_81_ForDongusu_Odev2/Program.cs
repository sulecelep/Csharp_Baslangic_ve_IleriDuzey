using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_81_ForDongusu_Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ÖDEV ÇARPIM TABLOSU
             * 1*1=1
             * 1*2=2
             * 1*3=3
             * ..
             * ..
             * 1*10=10
             * 
             * 2*1=2
             */

            for(int i = 1; i<=9;  i++)
            {
                for(int j= 1; j<=10; j++)
                {
                    int carpim = i * j;
                    Console.WriteLine(i+"*"+j+"="+carpim);
                }
                Console.WriteLine();
            }
        }
    }
}
