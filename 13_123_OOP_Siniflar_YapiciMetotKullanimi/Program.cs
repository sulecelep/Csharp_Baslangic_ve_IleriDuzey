using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_123_OOP_Siniflar_YapiciMetotKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Musteri M1 = new Musteri();  //normalde fault değerler null ve 0'dır biz bunu ezdik yapıcı metotla
            //buradaki ()'in içi boş ise yapıcı metodu dinler
            Musteri M1 = new Musteri("12345678912", "Şule");

            M1.TCKimliknumara = "12546532615";
            M1.isim = "Cengiz";
            M1.soyisim = "Atilla";
            M1.cinsiyet = 717770001;

        }
    }
}
