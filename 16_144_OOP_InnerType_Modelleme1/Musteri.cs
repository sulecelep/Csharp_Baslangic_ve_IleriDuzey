﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_144_OOP_InnerType_Modelleme1
{
	public class Musteri
	{
		#region Tekil olarak kullanılan fieldlar
		public int musteriID { get; set; }
		public string tcKimlikNumarasi { get; set; }
		public string isim { get; set; }
		public string soyisim { get; set; }
		public DateTime olusturmaTarih { get; set; }
		public int kullaniciId { get; set; }
		#endregion

		#region Inner Type gerektiren fieldlar
		public MusteriAdres[] musteriAdresListe; //dizi tanımladık
		public MusteriIletisimBilgisi[] musteriIletisimBilgileri;										 
		public MusteriSiparisBilgisi[] musteriSiparisBilgileri;
        #endregion

        public Musteri()
        {
			musteriAdresListe = new MusteriAdres[5];
			musteriIletisimBilgileri=new MusteriIletisimBilgisi[5];
			musteriSiparisBilgileri = new MusteriSiparisBilgisi[10];

        }
    }
}
