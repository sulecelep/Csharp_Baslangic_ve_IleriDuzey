using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_140_OOP_Static_ODEV
{
	public class Musteri
	{
		static ArrayList MusteriListesi;
		//static yapıcı metotta newleyebiliriz
		static Musteri()
		{
			MusteriListesi = new ArrayList();
		}

		public int ID { get; set; }
		public string Isim { get; set; }
		public string Soyisim { get; set; }
		public string _emailAdres {get; set;}
		private string _kullaniciAdi;
		public string KullaniciAdi 
		{
			get { return this._kullaniciAdi; }
			set
			{
				bool kullaniciAdiKontrol = MusteriKullaniciAdiKontrol(value);
				if(kullaniciAdiKontrol)
				{
                    Console.WriteLine("Bu kullanıcı adına sahip bir kullanıcımız bulunmaktadır.");
					this._kullaniciAdi=string.Empty;
                }
				else
				{
					this._kullaniciAdi = value;
				}
			}
		}
		public string Sifre {get; set;}

		

		public static void MusteriEkle(Musteri musteri)
		{
			if(musteri != null && !string.IsNullOrEmpty(musteri.KullaniciAdi) && !string.IsNullOrEmpty(musteri._emailAdres))
			{
				bool emailAdresKontrol=MusteriEmailAdresKontrol(musteri._emailAdres);
				if(emailAdresKontrol)
				{
					Console.WriteLine("Databaseimizde bu emaille kullanıcı kaydı bulunmaktadır.");
				}
				else
				{
					MusteriListesi.Add(musteri);
					Console.WriteLine("Müşteri sistemimize başarıyla eklenmiştir.");
				}
				
            }
			else
			{
				Console.WriteLine("Müsteri tipi kayıt için uygun değil.");
			}
		}

		//Static Metotlar
		static bool MusteriKullaniciAdiKontrol(string _kullaniciadi)
		{
			bool kontrol = false;
			for (int i = 0; i < MusteriListesi.Count; i++)
			{
				Musteri Temp = (Musteri)MusteriListesi[i];
				if (Temp._kullaniciAdi == _kullaniciadi)
				{
					kontrol = true;
					break;
				}
			}
			return kontrol;
		}
		static bool MusteriEmailAdresKontrol(string _emailAdres)
		{
			bool Kontrol = false;
			for(int i=0; i< MusteriListesi.Count; i++)
			{
				Musteri Temp = (Musteri)MusteriListesi[i];
				if(Temp._emailAdres == _emailAdres)
				{ 
					Kontrol = true; break; 
				}

		    }
			return Kontrol;
		}
	}
}
