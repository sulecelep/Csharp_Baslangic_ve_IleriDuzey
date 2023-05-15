using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_144_OOP_InnerType_Modelleme1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Musteri M1 = new Musteri();
			M1.musteriID = 1;
			M1.tcKimlikNumarasi = "12345678945";
			M1.isim = "Cengiz";
			M1.soyisim = "Atilla";
			M1.olusturmaTarih = DateTime.Now;

			//M1.musteriAdresListe = new MusteriAdres[5]; //Burada inner type i örneklememiz gerekiyor 1. yol //ASLA YAPMA
			M1.musteriAdresListe[0] = new MusteriAdres()
			{
				Il = "Istanbul",
				Ilce = "Gop",
				Adres = "Adres ...",
				adresTip = "İş Yeri"
			};

			M1.musteriAdresListe[0].MusteriAdresTestMetot();  //inner type'daki metoda ulaştık

			M1.musteriSiparisBilgileri[0] = new MusteriSiparisBilgisi()
			{
				siparisNumarasi = "SIP0001"
			};

			M1.musteriSiparisBilgileri[0].urunListesi[0] = new Urun()
			{
				UrunID = 1,
				UrunAdi = "Ülker Çikolatalı Gofret",
				UrunAciklamasi = "Çikolata kaplı fındık aromalı gofret",
				Fiyat = 10
			};
			M1.musteriSiparisBilgileri[0].urunListesi[0].UrunMetot();
		}
	}
}
