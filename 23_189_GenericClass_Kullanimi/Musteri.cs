using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_189_GenericClass_Kullanimi
{
	public class Musteri
	{
        public int Id { get; set; }
        public Guid musteriNumara { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime dogumTarih { get; set; }
    }
}
