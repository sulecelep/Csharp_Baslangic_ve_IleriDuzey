using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_167_OOP_Interface_Abstract_Nedir
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Genel olarak abstract sınıfların özelliklerini bir araya toplarsak;

			Abstract sınıfları genel olarak inheritance (kalıtım) uygularken kullanırız.
			new anahtar sözcüğü ile nesneleri oluşturulamaz.
			İçerisinde değişken ve metod bulundurabilir.
			Abstract sınıflardan türetilen sınıfların abstract metodları implement etmesi zorunludur. Diğer metodları override etmeden de kullanabilir.
			Constructors (yapıcı metodlar) ve destructors (yıkıcı metodlar) bulundurabilirler.
			Static tanımlanamazlar. ( Tanımlanmaya çalışılırsa compiler “an abstract class cannot be sealed or static” hatası verir)
			Bir sınıf yalnızca bir abstract sınıfı inheritance yoluyla implement edebilir. Çoklu kalıtım (multiple inheritance) desteklenmez.
			Abstract olmayan metodları da bulundurabilir.
			Kendisinden inherit alacak sınıflar ile arasında “is-a” ilişkisi vardır. 
			(Burası ilk başlarda çok önemsenmeyen ancak hangi senaryoda Abstract hangi senaryoda Interface kullanacağımızı netleştirmede bize oldukça yardımcı olan bir detaydır, hemen aşağıda açıklamasını bulabilirsiniz)
			 * 
			 * 
			 * Genel olarak Interface’lerin özelliklerinden bahsetmemiz gerekirse;

			new keywordü ile nesneleri oluşturulamaz.
			Bir sınıfın ne yapması gerektiğini belirtir, nasıl yapması gerektiğini değil.
			Default olarak tüm Interface üyeleri abstract ve public olarak tanımlanır. Sizin özellikle belirtmeniz gerekmez.
			Bir sınıf birden fazla interface’i inherit edebilir, çoklu kalıtım (multiple-inheritance) desteklenir.
			İçerisinde yalnızca metodların imzaları yer alır, içi dolu metod bulunduramazlar.
			Kendisinden inherit alacak sınıflar ile arasında “can-do” ilişkisi vardır.
			 */
		}
	}
}
