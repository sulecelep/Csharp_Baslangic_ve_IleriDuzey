using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_144_OOP_InnerType_Modelleme1
{
	public class MusteriAdres
	{
		public string adresTip { get; set; }
		public string Il { get; set; }
		public string Ilce { get; set; }
		public string Adres { get; set; }

        public MusteriAdres()
        {
            Console.WriteLine("MusteriAdres yapıcı metodu çalıştı...");
        }
        public void MusteriAdresTestMetot()
		{
            Console.WriteLine("MusteriAdresTestMetot"); 
        }
	}
}
