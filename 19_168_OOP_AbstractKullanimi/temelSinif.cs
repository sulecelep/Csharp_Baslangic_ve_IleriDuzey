using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_168_OOP_AbstractKullanimi
{
	public abstract class temelSinif
	{
        public DateTime kayitTarih { get; set; }
        public DateTime guncellemeTarih { get; set; }

        public temelSinif()
        {
            kayitTarih = DateTime.Now;
            guncellemeTarih = DateTime.Now;
        }
        public void test()
        {
            Console.WriteLine("temelSinif içindeki test metodu");
        }
        public abstract void abstractMetot(); //metot imzası
        
    }
}
