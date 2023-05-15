using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_PartialClass
{
	public partial class ogrenci
	{
		public int yeniKayit(ogrenci o)
		{
            Console.WriteLine("kayıt başarılı");
			return 1;
        }
		public int kayitGuncelle(ogrenci o)
		{
            Console.WriteLine("öğrenci kaydı güncellendi");
			return 1;
        }
		public int kayitSil(int id)
		{
            Console.WriteLine("ogrenci silindi");
			return 1;
        }
	}
}
