using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_Kalıtım
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Personel P1= new Personel();
			Ogrenci O1 = new Ogrenci();
			temelTip T1 = new temelTip();
			Egitmen E1 = new Egitmen();
			T1.TemelTipMetot1();
			E1.TemelTipMetot1();
			O1.TemelTipMetot1();
		    
            Console.WriteLine("Eğitmen nesnesi örneklendi");

			#region Boxing- Unboxing
			//Özel Tiplerde Boxing - Unboxing
			//Bizim object nesnemiz nedir? TemelTip
			temelTip T2;
			//hangi nesnelerde tmeel tip object görevi görür? personel eğitmen ogrenci
			//Temeltip nesnesinden türetildikleri için temel tip nesnesi bu nesnelerde  object gibi davranır..

			//object Obj2 = T2;

			//Boxing -- Unboxing
			object Obj1 = E1;  //Boxing
			E1 =(Egitmen)Obj1; //Unboxing


			T2 = E1; //Eğitmen nesnesini Temeltip nesnesine atadık
			E1 = (Egitmen)T2;
			T2 = P1; //Personel nesnesini temeltip nesnesine atadık
			P1 = (Personel)T2;
			T2 = O1; //Ogrenci nesnesini temeltip nesnesine atadık
			O1 = (Ogrenci)T2;

			//Bütün classlar(nesneler) object nesnesinden türer
			#endregion

			#region Türemiş olan tipler türeyemesin ( Sealed Anahtar Kelimesi )
			Test T3 = new Test();
			//T1.
			//Biz hangi nesnemizin kalıtılmasını istemiyoruz?
			//Egitmen classını sealed yapcaz

			Egitmen E2 = new Egitmen();
			#endregion

			#region Protected
			//Normal kullanımda private gibi sadece kendi classının içerisinden erişilebilir
			//kalıtım yolu ile başka bir class içerisinde public olarak kullanılır 
			temelTip T5  = new temelTip();
			
			#endregion

		}
	}
}
