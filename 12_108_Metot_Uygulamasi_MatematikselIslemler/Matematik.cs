using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_108_Metot_Uygulamasi_MatematikselIslemler
{
    public class Matematik
    {
        //Topla 
        public decimal ToplamaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc=sayi1+sayi2;
            return sonuc;
        }

        //Çıkarma İşlemi
        public decimal CikarmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        //Bolme Islemi
        public decimal BolmeIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }

        //Çarpma İslemi
        public decimal CarpmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc=sayi1 * sayi2;
            return sonuc;
        }
        public void MenuHazirla()
        {
            Console.Clear();
            Console.WriteLine("*** Menü ***");
            Console.WriteLine("1- Toplama");
            Console.WriteLine("2- Çıkarma");
            Console.WriteLine("3- Bölme");
            Console.WriteLine("4- Çarpma");
            Console.Write("Lütfen bir işlem seçiniz: ");
        }
        public void sonucEkranaYaz(decimal kullaniciSayi1, decimal kullaniciSayi2, decimal sonuc, string operators)
        {
            Console.WriteLine("{0} {1} {2} = {3}",kullaniciSayi1,operators,kullaniciSayi2); 
        }
    }
}
