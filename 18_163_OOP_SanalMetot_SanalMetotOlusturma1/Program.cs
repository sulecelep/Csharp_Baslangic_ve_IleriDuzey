using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_163_OOP_SanalMetot_SanalMetotOlusturma1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			televizyon T1 = new televizyon();
			T1.ekranaYaz("Hangi ekranaYaz çalısır?");
			urun U1=new urun();
			U1.ekranaYaz("urun nesnesi içerisinde bu metot çağırıldı.");

			baseClass B1=new baseClass();
			B1.ekranaYaz("baseClass nesnesi içerisinde bu metot çağırıldı.");
		}
	}
}
