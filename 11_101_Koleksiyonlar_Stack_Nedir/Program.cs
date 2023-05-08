using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_101_Koleksiyonlar_Stack_Nedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1000 satırlık data row u başarılıysa bu listeden çıkarmak istiyoruz
            //en son push edilen en önce çıkar yani 0. indexte en son eklenen olur
            Stack S1= new Stack();  
            S1.Push("Bir");
            S1.Push("İki");
            S1.Push("Üç");
            S1.Push("Dört");

            object O1=S1.Pop();  //datayı bana gönderdi ve kendisinden remove etti
            object O2=S1.Peek();  //datayı bana gönderecek ama silmeyecek önizleme yaptıracak
        }
    }
}
