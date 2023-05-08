using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_108_Metot_Uygulamasi_MatematikselIslemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik M = new Matematik();
            YenidenDene:
            M.MenuHazirla();
            int kullaniciSecim = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
            decimal kullaniciSayi1=decimal.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
            decimal kullaniciSayi2=decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;
            switch (kullaniciSecim)
            {
                case 1:
                    sonuc = M.ToplamaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");
                    break;
                case 2:
                    sonuc = M.CikarmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
                    break;
                case 3:
                    sonuc = M.BolmeIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "/");
                    break;
                case 4:
                    sonuc = M.CarpmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
                    break;
                default:
                    Console.WriteLine("Geçerli bir işlem türü girmediniz.");
                    Console.WriteLine("Lütfen yeniden deneyiniz.");
                    goto YenidenDene;
            }
            Console.WriteLine("Yeni İşlem yapmak istiyor musunuz? [E/H]");
            string EH = Console.ReadLine().ToUpper();
            if(EH =="E")
            {
                goto YenidenDene;
            }
        }
    }
}
