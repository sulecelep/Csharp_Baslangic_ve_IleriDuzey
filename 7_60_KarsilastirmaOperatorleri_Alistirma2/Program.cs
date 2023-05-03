using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_60_KarsilastirmaOperatorleri_Alistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Kullanıcı Adı : admin
                Şifre : 123

                Kullanıcı adını giiniz:
                Şifrenizi giriniz: 

             */

            Console.WriteLine("Kullanıcı adını giriniz: ");
            string kullaniciAdi= Console.ReadLine();

            Console.WriteLine("Şifrenizi giriniz: ");
            string sifre= Console.ReadLine();

            Console.Clear();

            string defaultKullaniciAdi = "admin";
            string defaultSifre = "123";

            bool kullaniciAdiKontrol = kullaniciAdi == defaultKullaniciAdi;
            Console.WriteLine("Kullanıcı Adı Doğru Mu? " + kullaniciAdiKontrol);

            bool kullaniciAdiKontrol2 = kullaniciAdi != defaultKullaniciAdi;
            Console.WriteLine("Kullanıcı Adı Farklı Mı? " + kullaniciAdiKontrol2);

            bool sifreKontrol = sifre == defaultSifre;
            Console.WriteLine("Sifre Doğru Mu? "+sifreKontrol);

            bool sifreKontrol2 = sifre != defaultSifre;
            Console.WriteLine("Sifre Yanlış Mı? " + sifreKontrol2);

            Console.ReadLine();


        }
    }
}
