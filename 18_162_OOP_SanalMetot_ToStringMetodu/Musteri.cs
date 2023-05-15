using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _18_162_OOP_SanalMetot_ToStringMetodu
{
	public class Musteri  // : Object yazmıyoruz => Framework zaten tüm nesneleri Object sınıfından türetiyor
	{
        public int musteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }

		public override string ToString()  //object nesnesindeki ToString metodu değil bizim burada yazdığımız metot çalışacak
		{
			return isim + " "+soyisim;
		}
	}
}
