using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_136_OOP_Static_StaticFieldKullanimi
{
	public class Personel
	{
		public static string domainAdres = "firmam.com"; //sabit değeri staticle belirtiyoruz
		public string Isim { get; set; }
		public string Soyisim { get; set; }

		private string _emailAdres;
		public string EmailAdres
		{
			get
			{
				return this._emailAdres;
			}
			set
			{
				this._emailAdres = value.ToLower()+"@"+Personel.domainAdres;
			}
		}
		public int Cinsiyet { get; set; }	
	}
}
