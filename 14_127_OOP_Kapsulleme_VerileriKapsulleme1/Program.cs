using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_127_OOP_Kapsulleme_VerileriKapsulleme1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Field içine değer atama yapılamasın ama değer okunabilsin
			 * Field içine değer taması yapılabilsin ama değer okunamasın
			 * Field değer ataması yapılsın ama değerin ilk 4 hanesi görülsün
			 * Field içerisine field ataması ve okuması yapılsın ama bu işlem
			 bizim belirlediğimiz bir süreçten geçsin daha sonra gösterilsin
			 * 
			 */

			//Class
			//Field
			//Property
			//Get & Set

			Musteri M1 = new Musteri();	
			M1.id = 1;
			M1.isim = "Şule";
			M1.soyisim = "Celep";
			//M1.emailAdres = "dsf"; //Field
			M1.EmailAdres = "sulecelep@gmail.com";
			Console.Write(M1.EmailAdres);
		}
	}
}
