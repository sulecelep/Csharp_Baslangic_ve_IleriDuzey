using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_144_OOP_InnerType_Modelleme1
{
	public class MusteriSiparisBilgisi
	{
		public string siparisNumarasi { get; set; }
		public Urun[] urunListesi;
		public void MusteriSiparisBilgisiTestMetot()
		{
            Console.WriteLine("MusteriSiparisBilgisiTestMetot");
        }

        public MusteriSiparisBilgisi()
        {
			urunListesi = new Urun[5];
        }
    }
}
