using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_133_OOP_Static_StaticNedir1
{
	public class Ogrenci //internal da olabilirdi
	{
		public string Isim { get; set; }
		public string Soyisim { get; set; }
		public string EmailAdres { get; set; }	
		public void Test1()
		{
            Console.WriteLine("Nesne öreneği alındıktan sonra çalışan metottur");
        }
		public static void Test2()
		{ 
			Console.WriteLine("Nesne örneği alınmadan ");
		}
	}
}
