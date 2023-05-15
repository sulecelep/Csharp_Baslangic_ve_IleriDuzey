using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_128_OOP_Kapsulleme_VerileriKapsulleme2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Musteri M1 = new Musteri();
			//M1.id = 1;
			//M1.isim = "Şule";
			//M1.soyisim = "Celep";
			//M1.emailAdres = "dsf"; //Field
			M1.EmailAdres = "sulecelep@gmail.com";
			Console.Write(M1.EmailAdres);

			//1. Field değer ataması yapılamasın ama değer okunabilsin
			Console.WriteLine("Musteri Id: "+M1.ID.ToString());
			//M1.ID = 10; //private set yaptığımız için değer atayamadık
		}
	}
}
