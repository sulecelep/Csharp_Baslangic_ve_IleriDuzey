using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_127_OOP_Kapsulleme_VerileriKapsulleme1
{
	internal class Musteri
	{
		//Fieldlar
		public int id;
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
	}
}
