﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_171_OOP_InterfaceKullanımı
{
	public class musteri : Imusteri
	{
		int _id;
		string _isim;
		string _soyisim;

		public int Id { get { return _id; } set { _id = value; } }
		public string isim { get { return _isim; } set { _isim = value; } }
		public string soyisim { get { return _soyisim; } set { _soyisim = value; } }

		public int kayitDuzenle(int id, string isim, string soyisim)
		{
            Console.WriteLine("kayıt düzenlendi");
			return 1;
			
        }

		public int kayitSil(int id)
		{
			Console.WriteLine("kayıt silindi");
			return 1;
		}

		public int yeniKayit(string isim, string soyisim)
		{
			Console.WriteLine("kayıt eklendi");
			return 1;
		}
	}
}
