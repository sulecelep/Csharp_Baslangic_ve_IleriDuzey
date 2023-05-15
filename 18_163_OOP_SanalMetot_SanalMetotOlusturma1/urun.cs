using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_163_OOP_SanalMetot_SanalMetotOlusturma1
{
	public class urun:baseClass
	{
		public urun()
		{
			Console.WriteLine("urun nesnesinin yapıcı metodu çalıştı.");
		}
		public override void ekranaYaz(string data)
		{
            Console.WriteLine("urun sınıfı => " + data); 
        }
	}
}
