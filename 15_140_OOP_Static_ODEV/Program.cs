using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_140_OOP_Static_ODEV
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Müşteri adında bir nesne oluşturalım +
			 * Bu nesnenin içerisinde static olarak bir ArrayList oluşturalım.+
			 * Oluşturmuş olduğumuz ArrayList koleksiyonumuzu sanal bir database mantığında kullanacağız.
			 * 
			 * Müşteri sınıfımızın içerisine
			 * ID, Isim, Soyisim, EmailAdres, KullaniciAdi, Sifre fieldları oluşturalım.
			 * Oluşturmuş olduğumuz bu field listesinden bazılarının kapsülleme
			 * filtreleri aşağıdaki gibi olmalıdır.
			 * Kullanıcı adı değeri sanal olarak oluşturmuş olduğumuz databaseimiz içerisinde aransın
			 * eğer kullanıcı adı sanal database içerisinde bulunursa field içerisine eklenmek istenen 
			 * değer eklenemesin(Kapsülleme)
			 * 
			 * Müşteri ekle adında bir static metot oluşturalım parametre olarak müşteri tipi alsın metot içerisinde
			 * Müşteri nesnesinin null olup olmadığını ve müşteri nesnesi içerisindeki kullanıcı adının dolu olması şartına
			 * baksın
			 * Yukarıdaki kriterlerden geçerse müşterimizi sanal olarak databaseimize eklemeden önce email adresinden
			 * bir kontrol sağlasın eğer sistemde aynı email adresi ile bir müşteri değeri var ise eklemesin yok ise 
			 * sanal database içerisine ilgili nesneyi eklesin.
			 */
			Musteri musteri = new Musteri();
			musteri.ID = 1;	
			musteri.Isim = "Cengiz";
			musteri.Soyisim = "Atilla";
			musteri._emailAdres = "cengiz@gmail.com";
			musteri.KullaniciAdi = "cengiz";
			musteri.Sifre = "1";
			Musteri.MusteriEkle(musteri);

			Musteri M2 = new Musteri()
			{
				ID = 2,
				Isim = "Şule",
				Soyisim = "Celep",
				_emailAdres = "sule@gmail.com",
				KullaniciAdi = "sule",
				Sifre = "2"
			};

			Musteri.MusteriEkle(M2);


			Musteri M3 = new Musteri()
			{
				ID = 3,
				Isim = "Merve",
				Soyisim = "Atasoy",
				_emailAdres = "sule@gmail.com",
				KullaniciAdi = "sule",
				Sifre = "3"
			};

			Musteri.MusteriEkle(M3);

		}
	}
}
