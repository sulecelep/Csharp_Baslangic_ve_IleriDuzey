using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_133_OOP_Static_StaticNedir1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Static (Ram'in static bölümü)
			 * Nesne örneği alınmadan ulaşabildiğimiz bir metot, field veya nesne üretemediğimiz static bir class olabilir.
			 * =new kısmı olmayacak yani nesne örneği alamıyoruz
			 * Tip.
			 */
			Ogrenci O1;
			Ogrenci.Test2();
			//Stack bölgede pointer oluştuğu zaman static olan bir
			//yapıcı metot çalıştı ve yine class içerisinde tanımlı olan
			//static field, metot static dediğimiz bölgede oluşturuldu
			O1=new Ogrenci();
			//tack bölgede pointer => kendisini heap bölgede tamamladı.. static olmayan
			//tanımlarını tamamladı..
			O1.Test1(); //nesne örneği alındıktan sonra test1 adındaki metoda ulaşabildim
		}
	}
}
