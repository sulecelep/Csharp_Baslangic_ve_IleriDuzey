using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_162_OOP_SanalMetot_ToStringMetodu
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Örnek olarak;
			 * temelTip adında sınıfımızı urun sınıfı kalıttığı zaman temelTip içerisinde
			 * bulunan metotlara ve özelliklere erişilebiliyor temelTip içerisindeki tanımları
			 * gibi kullanabiliyordu.
			 * 
			 * temelTip içerisinde ekranaYaz adında bir metot olsa urun sınıfı içerisinde bulunan
			 * şekli ile çalışıp metot işlemini tamamlayabiliyordu.
			 * 
			 * Sanal metot dediğimiz bu bölümümüzde temelTip içerisinde bulunan bir metotun 
			 * istenilirse türeyen sınıf içerisinde nasıl yeniden şekillendirilebileceğini inceleyeceğiz.
			 * 
			 * Kalıtım konusunda tüm nesnelerin object nesnesinden kalıtıldığını ve bazı metotların 
			 * object nesnesinden bize geldiğini söylemiştik.
			 * 
			 * Birazdan sanal metot anlatımına object içerisinde bize standart olarak gelen toString metodunu
			 * inceleyerek başlayacağız.
			 * 
			 * Sanal metotları, X-men filminde bulunan mystique karakterine benzetebilirsiniz.
			 * Ortama göre kendi şeklini değiştirebilen bir karakter olması buna bir örnek olabilir.
			 */

			/*
			 * TO STRING();
			 * 
			 * Object => ToString();
			 * 
			 * Musteri M1=new Musteri();
			 * Object => Musteri 
			 * M1.ToString();
			 * 
			 * Namespace.Musteri
			 * 
			 * 
			 */

			Musteri M1 = new Musteri();
			M1.isim = "Şule";
			M1.soyisim = "Celep";
			string toStringMesaj=M1.ToString();  //namespace.Musteri yazmasını bekliyoruz.
            Console.WriteLine(toStringMesaj);

        }
	}
}
