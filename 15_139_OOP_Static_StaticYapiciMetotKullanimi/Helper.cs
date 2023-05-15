using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_139_OOP_Static_StaticYapiciMetotKullanimi
{
	public class Helper
	{
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
