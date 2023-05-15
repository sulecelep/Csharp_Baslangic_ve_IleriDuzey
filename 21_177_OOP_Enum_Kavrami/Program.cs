using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_177_OOP_Enum_Kavrami
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Müşteri kaydı
			Musteri M1 = new Musteri();
			M1.Id = 1;
			M1.musteriNumara = "MSN001";
			M1.isim = "Cengiz";
			M1.soyisim = "Atilla";
			M1.emailAdres = "cengiz@gmail.com";

			sanalDatabase SB = new sanalDatabase();
			musteriReturnValue musteriKayitSonuc=SB.musteriYeniKayit(M1);
			if(musteriKayitSonuc==musteriReturnValue.kayitBasarili)
			{
                Console.WriteLine("kayıt başarılı");
            }
		}
	}
}
