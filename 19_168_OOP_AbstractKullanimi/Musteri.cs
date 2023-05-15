using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_168_OOP_AbstractKullanimi
{
	public class Musteri:temelSinif
	{
        public int musteriID { get; set; }
        public Musteri()
        {
            musteriID = 1;
        }

		public override void abstractMetot()
		{
            Console.WriteLine("Müşteri => abstractMetot");
        }
	}
}
