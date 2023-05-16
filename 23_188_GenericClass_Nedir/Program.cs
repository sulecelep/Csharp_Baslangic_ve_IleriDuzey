using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_188_GenericClass_Nedir
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Musteri M1 = new Musteri();	
			M1.Id = 1;
			M1.musteriNumara = "MN121";
			M1.TcKimlikNumarasi = "12345678912";
			M1.isim = "Şule";
			M1.soyisim = "Celep";
			M1.DogumTarih = DateTime.Parse("14.06.1994");

			MusteriGeneric<int> MusteriGeneric1 = new MusteriGeneric<int>();	
			MusteriGeneric1.Id = 1;
			MusteriGeneric1.musteriNumarasiAl();

			MusteriGeneric<Guid> MusteriGeneric2 = new MusteriGeneric<Guid>();
			MusteriGeneric2.musteriNumarasiAl();
		}
	}
}
