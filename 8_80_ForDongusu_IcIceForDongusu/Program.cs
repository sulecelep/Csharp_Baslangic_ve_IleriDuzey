using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_80_ForDongusu_IcIceForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //iç içe for döngüsü
            for(int i=1; i<=20; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Clear();
        }
    }
}
