using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_177_OOP_Enum_Kavrami
{
	public class sanalDatabase
	{
		ArrayList sanalDB = new ArrayList();	

		public musteriReturnValue musteriYeniKayit(Musteri M)
		{
			//parametre kotrol
			//kayit kontrol
			sanalDB.Add(M);
			return musteriReturnValue.kayitBasarili;
		}
	}
}
