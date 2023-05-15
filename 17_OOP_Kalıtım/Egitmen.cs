using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_Kalıtım
{
	public sealed class Egitmen:Personel
	{
        public string Brans { get; set; }
        public int BransSeviye { get; set; }
		

        public Egitmen()
        {
            Console.WriteLine("Eğitmen nesnesinin yapıcı metodu çalıştı");
            TemelTipMetot1();
            IdAtamaIslemi();
        }
    }
}
