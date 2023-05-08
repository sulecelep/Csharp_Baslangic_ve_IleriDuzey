using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_100_Koleksiyonlar_SortedList_Nedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // keylerin benzersiz ve aynı data tipinde olması gerekir çünkü sıralama yaparak getirir
            // System.Collections.Generic olmayacak

            SortedList SortedL = new SortedList();
            //sayıları küçükten büyüğe doğru sıralar
            SortedL.Add(100, "Yüz");
            SortedL.Add(90, "Doksan");
            SortedL.Add(1, "Bir");
            SortedL.Add(9000, "Dokuzbin");
        }
    }
}
