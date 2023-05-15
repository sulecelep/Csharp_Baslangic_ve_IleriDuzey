using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_137_OOP_Static_StaticMetotKullanimi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Personel P1 = new Personel();
			P1.Isim = "Cengiz";
			P1.Soyisim = "Atilla";
			P1.EmailAdres = String.Format("{0}.{1}", P1.Isim, P1.Soyisim);
			P1.Cinsiyet = 717770001; //Bay 717770002: Bayan
			Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.Isim+P1.Soyisim);
		}
	}
}
