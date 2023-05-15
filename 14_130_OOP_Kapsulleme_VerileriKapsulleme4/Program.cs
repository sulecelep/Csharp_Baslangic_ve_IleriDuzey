using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_130_OOP_Kapsulleme_VerileriKapsulleme4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Musteri M1 = new Musteri();
			M1.isim = "Şule";
			M1.Soyisim = "Celep";
            Console.WriteLine(M1.EmailAdres);
        }
	}
}
