using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_PartialClass
{
	public class musteri
	{
        public int Id { get; set; }
        public string  isim { get; set; }
        public string  soyisim { get; set; }
        public string  emailAdres { get; set; }

        public int yeniKayit(musteri m )
        {
            Console.WriteLine("db'e kayıt tamamlandı");
            return 1;
        }
        public int kayitGuncelle(musteri m)
        {
            Console.WriteLine("musteri kaydı gücellendi");
            return 1;
        }
        public int kayitSil(int id)
        {
            Console.WriteLine("kayıt silindi");
            return 1;
        }
    }
}
