using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_163_OOP_SanalMetot_SanalMetotOlusturma1
{
	public class baseClass
	{
		/*
		 
	    virtual anahtar kelimesini kullandığımızda metot sanal metot olur.
        ToString() metodu da object sınıfında virtual anahtar kelimesi ile yazıldığı için
		biz override edip kendi istediğimiz gibi çalıştırabildik.

		çalışırken önce baseClass>urun>televizyon olarak gidiyor. 
		temel sınıftan başlıyor yapıcı metodunu ve virtual metotlarını kaydedip ona göre
		override edilen varsa onu çalıştırıyor.

		 */
		public baseClass()
        {
			Console.WriteLine("baseClass nesnesinin yapıcı metodu çalıştı.");
		}
        public virtual void ekranaYaz(string data)
		{
            Console.WriteLine(data);
        }
	}
}
