using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_128_OOP_Kapsulleme_VerileriKapsulleme2
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
		public string soyisim;

		//private yapsak programda ulaşamayız bu yüzden görünürlüğünü get'i kapatcaz

		private string emailAdres = "sule@gmail.com";
		public string EmailAdres
		{
			//get; //db ya da farklı bir veri kaynağından çekip gösterir..
			//classı çağıran programcıya datayı gösterir

			//set;  //kullanıcıdan alınan datanın içeride private olarak saklanan 
			//field içine değer atandığı kısım

			set
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
