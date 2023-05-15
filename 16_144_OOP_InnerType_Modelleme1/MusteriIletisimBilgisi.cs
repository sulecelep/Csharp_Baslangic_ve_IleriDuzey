using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_144_OOP_InnerType_Modelleme1
{
	public class MusteriIletisimBilgisi
	{
		public int iletisimTip { get; set; }	// 717770001:Mobil  717770002:Sabit
		public string alanKodu { get; set; }	
		public string numara { get; set; }	
		public bool aktifPasif { get; set; }

		public void MusteriIletisimBilgisiTestMetot()
		{
            Console.WriteLine("MusteriIletisimBilgisiTestMetot");
        }
	}
}
