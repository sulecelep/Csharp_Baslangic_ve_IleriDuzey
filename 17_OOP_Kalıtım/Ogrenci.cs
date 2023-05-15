using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_Kalıtım
{
	public sealed class Ogrenci: temelTip
	{
        public string bolum { get; set; }
        public int seviye { get; set; }

        public Ogrenci()
        {
            Console.WriteLine("Ogrenci yapıcı metodu çalıştı.");
            IdAtamaIslemiOgrenci();
            TemelTipMetot2(); //Protected metodunu Ogrenci nesnesi temeltip nesnesinden
            //kalıtım yoluyla türetildiği için ulaşabildim, field ve metotlara erişilebilir
        }
    }
}
