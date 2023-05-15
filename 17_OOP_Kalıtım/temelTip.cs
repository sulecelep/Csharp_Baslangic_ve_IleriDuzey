using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_Kalıtım
{
	public class temelTip
	{
		public int id { get; set; }
		public string referansKod { get; set; }
		public string tcKimlikNumarasi { get; set; }
		public string isim { get; set; }
		public int cinsiyet { get; set; }
		public DateTime kayitTarih { get; set; }
		public DateTime guncellemeTarih { get; set; }
        public int kayitKullanici { get; set; }
        public int guncellemeKullanici { get; set; }
		public bool silindi { get; set; }

        public temelTip()
        {
            Console.WriteLine("temelTip nesnesinin yapıcı metodu çalıştı");
			//IdAtamaIslemi();
			
        }
		internal void IdAtamaIslemi()
		{
			Random random = new Random();
			this.id= random.Next(1000,9000);
		}
		internal void TemelTipMetot1()
		{
            Console.WriteLine("Temel Tip =>Metot1");
			//TemelTipMetot2(); // Protected old için clas içerisinde private gibi davranır
        }
		internal void IdAtamaIslemiOgrenci()
		{
			Random random = new Random();
			this.id = random.Next(1, 1000);
		}
		protected void TemelTipMetot2()
		{
            Console.WriteLine("Protected metot temel tip");
        }
	}
}
