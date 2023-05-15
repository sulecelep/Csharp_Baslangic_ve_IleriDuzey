using _20_OOP_PartialClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_174_OOP_PartialClass
{
	internal class Program
	{
		static void Main(string[] args)
		{
			musteri m1 = new musteri();	
			m1.Id = 1;
			m1.isim = "Cengiz";
			m1.soyisim = "Atilla";
			m1.emailAdres = "cengiz@hotmail.com";

			int sonuc = m1.yeniKayit(m1);
			if(sonuc > 0)
			{
				Console.WriteLine("db'e kayıt eklendi.");
			}
			ogrenci O1 = new ogrenci();
			O1.yeniKayit(O1);
		}
	}
}
