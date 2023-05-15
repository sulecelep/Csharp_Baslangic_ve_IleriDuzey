using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_181_GenericKoleksiyonlar_ListT_Kullanimi_1_2_
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//ArrayList'in generic versiyonu
			ArrayList list = new ArrayList();
			list.Add(1);
			list.Add("bir");

			//<T> tipi demek .net framework içerisinde olan veya bizim
			//oluşturduğumuz herhangi bir tip, int strig veya bir class'da olablir

			List<int> listeGeneric = new List<int>();
			listeGeneric.Add(1);

			for(int i=0; i < listeGeneric.Count; i++)
			{
				Console.WriteLine(listeGeneric[i]);
            }

			List<string> isimler = new List<string>();
			isimler.Add("Şule");
			isimler.Add("Cengiz");
			isimler.Add("Atilla");

			for (int i = 0; i < isimler.Count; i++)
			{
				Console.WriteLine(isimler[i]);
			}

			List<musteri> musteriListe = new List<musteri>();
			musteriListe.Add(new musteri()
			{
				id = 1,
				isim = "Şule",
				soyisim="Celep"
			});

			foreach (musteri item in musteriListe)
			{
				Console.WriteLine(item.isim);
			}
		}
	}
}
