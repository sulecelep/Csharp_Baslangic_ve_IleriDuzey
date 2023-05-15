using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_171_OOP_InterfaceKullanımı
{
	public interface Imusteri
	{
        //interface içerisinde yapıcı metot kullanılamaz.
        //nesne örneği alamayız. newleyemeyiz.
        //hiçbir metodun scope'u yani body'si bulunmaz.

        //içerisinde;
        // 1- metot imzaları olur.
        int yeniKayit(string isim, string soyisim);
        int kayitDuzenle(int id, string isim, string soyisim);
        int kayitSil(int id);

        // 2- field olur (get set yapmazsak değişken oluşturmuş oluruz, interface'de değişkenler olmaz.
        int Id { get; set; }
        string isim { get; set; }
        string soyisim { get; set; }
        // 3- delegate olur vb.

    }
}
