using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_77_ForDongusu_IkiOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ekran üzerinde 1-10 arasındaki değerleri yazdıralım
            for(int i = 0; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            #endregion
            Console.Clear();

            #region 1-100 arasındaki çift sayıları ekran üzerinde yazdıralım.
            for (int j = 0; j <= 100; j++)
            {
                if(j%2==0)
                {
                    Console.WriteLine(j + " çift sayıdır");
                }
            }
            #endregion
            Console.Clear();
            #region Küçük ödev: 1-100 arasındaki çift sayıların toplamı
            var toplam = 0;
            for (int j = 0; j <= 100; j++)
            {
                if (j % 2 == 0)
                {
                    toplam += j;
                }
            }
            Console.WriteLine(toplam);

            #endregion
            Console.ReadLine();
        }
    }
}
