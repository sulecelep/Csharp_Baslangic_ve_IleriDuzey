using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_183_GenericKoleksiyonlar_ListT_Kullanimi_3_4_5_
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> sayilarim = new List<int>();
			sayilarim.Add(1);

			
			int[] eklenecekData1 = new int[4];
			eklenecekData1[0] = 2;
			eklenecekData1[1] = 3;
			eklenecekData1[2] = 4;
			eklenecekData1[3] = 5;

			//1. yol ama uzun bir yol
			//for(int i = 0; i < eklenecekData1.Length; i++)
			//{
			//	sayilarim.Add(eklenecekData1[i]);
			//}

			//2. yol 
			sayilarim.AddRange(eklenecekData1);

			//-------------------------------------------------------------

			int capacity=sayilarim.Capacity;
			int count=sayilarim.Count;
			sayilarim.TrimExcess();  //count ile capacity'i eşitler


			//Soru : sayilarim koleksiyonu içerisinde bulunan datayı ekrana yazdırmak istiyorum.
			//bunu nasıl yaparsınız?

			//foreach(var item in sayilarim)
			//{
			//   Console.WriteLine(item);
			//}

			//linq ile ForEach metodu geldi
			sayilarim.ForEach(item => Console.WriteLine(item)); //yukarıdaki foreach bu şekilde de yazılır

			int bulunanDeger = sayilarim[3];
            Console.WriteLine("List<T> koleksiyonu içerisinde 3. indexteki değer: {0}",bulunanDeger);

			sayilarim.Insert(3, 100);  //3. index'e 100'ü getir daha önceden bir değer varsa onu alta kaydırır silmez
			//sayilarim.InsertRange(6, sayilarim); //6. index dahil sayilarim koleksiyonunu sayilarima ekle
			bool kontrol1 = sayilarim.Any(); // koleksiyonda deger varsa true döner
			bool kontrol2 = sayilarim.Any(i=>i>5); //koleksiyonda 5'ten büyük varsa true dön 
												   //içerde belirlediğimiz şarta göre bize true döndü i burada koleksiyondaki her bir değeri temsil ediyor


			int enYuksekDeger= sayilarim.Max();
			int enDusukDeger = sayilarim.Min();
			int toplamDeger = sayilarim.Sum();

			//Uygulama Alanı => Bölüm
			//List<T> Uygulama - Windows Form

			sayilarim.Sort(); //A-Z'ye sıralar
			sayilarim.Reverse(); //öncesinde Sort metodu kullanmak şartıyla Z-A'ya doğru sıralar.
								 //Reverse index'e göre ters sıralar

			bool silmeIslemiSonuc = sayilarim.Remove(100); // geriye bool döner. 100'ü silerse true
			int silinenAdet= sayilarim.RemoveAll(i => i < 4);  //i 4 ten küçük olanları siler ve silinen değerlerin sayısını geri döner

			sayilarim.RemoveAt(2); //2.indexi siler 
			sayilarim.Clear(); //komple siler

        }
	}
}
