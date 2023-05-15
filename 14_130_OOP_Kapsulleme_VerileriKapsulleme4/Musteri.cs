using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_130_OOP_Kapsulleme_VerileriKapsulleme4
{
	internal class Musteri
	{
		//Fieldlar
		public Musteri()
		{
			this.id = IDUret();
		}
		private int id;
		public int ID
		{
			get
			{
				return this.id;
			}
			private set
			{
				this.id = value;
			}
		}
		public string isim;
		private string _soyisim;
		public string Soyisim
		{
			get { return this._soyisim; }
			set
			{
				this._soyisim = value;
				this.emailAdres = string.Format("{0}.{1}@hotmail.com",isim,_soyisim);
			}
		}
		//private yapsak programda ulaşamayız bu yüzden görünürlüğünü get'i kapatcaz

		private string emailAdres = "sule@gmail.com";
		public string EmailAdres
		{
			
			private set
			{
				this.emailAdres = value;  //value gelen datayı tutuyor
			}
			get
			{
				return this.emailAdres;
			}
		}

		private int IDUret()
		{
			Random rnd = new Random();
			return rnd.Next(10000, 90000);
		}
	}
}
