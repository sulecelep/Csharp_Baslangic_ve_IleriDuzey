using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_139_OOP_Static_StaticYapiciMetotKullanimi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Static Yapıcı Metot ile Standart Yapıcı Metot Arasındaki Farklar
			 * Uygulama önce static yapıcı metodu çalıştır
			 */
			Personel P1 = new Personel();
			P1.Isim = "Cengiz";
			P1.Soyisim = "Atilla";
			P1.EmailAdres = String.Format("{0}.{1}", P1.Isim, P1.Soyisim);
			P1.Cinsiyet = 717770001; //Bay 717770002: Bayan

			Personel P2 = new Personel();
			P2.Isim = "Cengiz";
			P2.Soyisim = "Atilla";
			P2.EmailAdres = String.Format("{0}.{1}", P2.Isim, P2.Soyisim);
			P2.Cinsiyet = 717770001; //Bay 717770002: Bayan

			Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.Isim + P1.Soyisim);
			Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P2.Isim + P2.Soyisim);
		}
	}
}
