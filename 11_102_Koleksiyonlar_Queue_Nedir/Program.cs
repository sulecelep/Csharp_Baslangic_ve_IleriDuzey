using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_102_Koleksiyonlar_Queue_Nedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // stack ile aynı ama bunda ilk giren ilk çıkar

            Queue Q1 = new Queue();
            Q1.Enqueue(1);
            Q1.Enqueue(2);
            Q1.Enqueue(3);
            Q1.Enqueue(4);

            object O1=Q1.Peek();   //değeri bize gönderdiktn sonra silmez
            object O2= Q1.Dequeue();  //0. indexten başlar değeri bize gönderir ve siler
        }
    }
}
