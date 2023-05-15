using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_144_OOP_InnerType_Modelleme1
{
	public class Urun
	{
		public int UrunID { get; set; }
		public string UrunAdi { get; set; }
		public string UrunAciklamasi { get; set; }
		public decimal Fiyat { get; set; }

        public Urun()
        {
            Console.WriteLine("Urun yapıcı metot çalıştı..");
        }

		public void UrunMetot()
		{
            Console.WriteLine("Metot çalıştı");
        }
    }
}
