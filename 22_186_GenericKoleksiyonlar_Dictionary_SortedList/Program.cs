using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_186_GenericKoleksiyonlar_Dictionary_SortedList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Generic Olmayan Koleksiyon Davranışı
			Hashtable HTList = new Hashtable();
			HTList.Add(1,"Bir");
			HTList.Add(2,"İki");
			HTList.Add(3,"true");
			HTList.Remove(0); //index'e göre siliyor
			string indexBir= HTList[1].ToString();
			
			//Dictionary<TKey,TValue>
			Dictionary<int,string> DictionaryList = new Dictionary<int,string>();
			DictionaryList.Add(1, "Bir");
			DictionaryList.Add(2, "İki");
			DictionaryList.Add(3, "Üç");

			bool silmeSonuc=DictionaryList.Remove(1);
			if(silmeSonuc )
			{ 
				Console.WriteLine("Silindi"); 
			}
			else
			{
                Console.WriteLine("Silme islemi başarısız");
            }

			bool arananKeySonuc= DictionaryList.ContainsKey(1); //varsa true yoksa false 
			if(arananKeySonuc)
			{
				string gelenDeger = DictionaryList[1];
				gelenDeger = "Yenilenen Değer"; //ezerek güncelledik
				DictionaryList[1] = gelenDeger;
			}
			else
			{
                Console.WriteLine("Aranan değer koleksiyon içerisinde bulunamadı.");
            }

			bool arananDegerSonuc = DictionaryList.ContainsValue("Üç"); //Bir değeri varsa true döner
			if (arananDegerSonuc)
			{
				Console.WriteLine("Aranan değer bulundu");
			}
			else
			{
				Console.WriteLine("Aranan değer bulunamadı");
			}

			foreach(KeyValuePair<int,string> item in DictionaryList)
			{
				Console.WriteLine("Anahtar: {0} || Değer : {1}",item.Key,item.Value);
			}
			DictionaryList.Clear(); //hepsini siler

			//Dictionary'nin aynısını yapar tek fark TKey'e göre A'dan Z'ye sıralar 
			//küçükten büyüğe sıralar

			SortedList<int,string> sortedList = new SortedList<int,string>();
			sortedList.Add(100, "Yüz");
			sortedList.Add(50, "Elli");
			sortedList.Add(1, "Bir");
			sortedList.Add(1000, "Bin");
		}
	}
}
