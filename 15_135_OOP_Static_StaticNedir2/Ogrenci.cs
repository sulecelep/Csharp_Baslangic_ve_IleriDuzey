using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_134_OOP_Static_StaticNedir2
{
	internal class Ogrenci
	{
		public string Isim { get; set; }
		public string Soyisim { get; set; }
		public string EmailAdres { get; set; }
		public void Test1()
		{
			Console.WriteLine("Nesne öreneği alındıktan sonra çalışan metottur");
			Test2(); //Static olmayan bir metodun içerisinde static metot çağırılabilir
		}
		public static void Test2()
		{
			Console.WriteLine("Nesne örneği alınmadan kullanılabilir");
			//Test1(); //Static olmayan bir metodu static metot içerisinde çağıramayız
			//static olmayana ulaşabilmesi için önce nesne örneğine ihtiyac duyar
		}
	}
}
