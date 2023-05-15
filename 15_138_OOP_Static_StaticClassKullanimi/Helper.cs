using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_138_OOP_Static_StaticClassKullanimi
{
	public static class Helper
	{
        /**
		 * Static olan classlar içerisinde standart metotlar kullanamaz. (staic olmayan metotlar)
		 * public string Isim{get, set;}
		 * Static olan classlar içerisinde olmayan field tanımları yapılamaz
		 */

        //public Helper()
        //{
            //Her nesne örneği alındığında uygulama standart yapıcı metodu çalıştırır.
        //}
        static Helper()
        {
            //Uygulama içerisinde istenildiği kadar çağırılsınlar sadece ilk çağırımda çalışırlar
            Console.WriteLine("Helper => Static class =>static CTOR"); 
        }
        public static void emailGonder(string aliciEmailAdres, string konu, string icerik)
		{
			Console.WriteLine("Mail gönderme işlemi başarılı.");
		}

		
		
	}
}
