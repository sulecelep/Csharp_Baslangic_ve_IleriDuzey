using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_196_WindowsForm_FormlarArasiVeriTasimak
{
	public class sanalDatabase
	{
		public static List<kullanici> KullaniciTablo = new List<kullanici>();
		static sanalDatabase()
		{
			KullaniciTablo.Add(new kullanici()
			{
				id = 1,
				isim = "Şule",
				soyisim = "Celep",
				kullaniciAdi = "sule",
				sifre = "1",
				aciklama = "Şule Celep Kullanıcı Profil Bilgisi"
			});

			KullaniciTablo.Add(new kullanici()
			{
				id = 2,
				isim = "Cengiz",
				soyisim = "Atilla",
				kullaniciAdi = "cengiz",
				sifre = "2",
				aciklama = "Cengiz Atilla Kullanıcı Profil Bilgisi"
			});
		}
	}
}
