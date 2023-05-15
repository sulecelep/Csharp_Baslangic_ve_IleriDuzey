using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_168_OOP_AbstractKullanimi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//temelSinif T1 = new temelSinif();	
			Musteri M1 = new Musteri();
			superMusteri S1= new superMusteri();
			S1.abstractMetot();
			M1.test();
			M1.abstractMetot();
		}
	}
}
