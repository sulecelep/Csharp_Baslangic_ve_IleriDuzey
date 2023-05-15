using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_135_OOP_Static_NedenVeNerelerdeKullanilir
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Static Kavramı gerçek hayatta nerelerde kullanılır..
			 * 1- Helper.cs => Kontroller (dağınık haldeki kontrollerimizi
			 * bir classın içinde toplamak için yapılır
			 * 2- Oluşturmuş olduğumuzmuz nesnemizin => bağımlılığı farklı classlara olduğu için
			 * (proje içerisinde özel old için) nesne içerisinde static metot tanımları
			 * yapılr.
			 * 3- Class içerisinde bir field (static) tanımı yapar ilgili field içerisine bir değer
			 * ataması yaparız. Daha sonra uygulama içerisinde N farklı yerde oluşturmuş olduğumuz static 
			 * fieldımıza ulaşır değerimizi okuruz.
			 * 4- [Uygulama] =>[ozelHelper] => [DLL] //Apilerde
			 * 
			 */
		}
	}
}
