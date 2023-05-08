using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_107_YeniMetotTanimlamak
{
    public class Ogrenci
    {
        public void SelamlaOgrenci()
        {
            Console.WriteLine("Merhaba Öğrenci"); 
        }

        /*
         * [ErişimBelirleyicisi] <GeriDonusDeger> MetotAdi (Parametreler)
         * {
         *      //Metot için gereken kodlar
         * }
         * 
         * Erişim belirleyicisi:
         * Public: metot classa herkesin ulaşabilmesini sağlıyor
         * Private: sadece içinde bulunduğu class'ın içerisinde çaĞırılabilir
         * Protected: Birbirinden sınıflar kalıtıldığında ulaşılabiliyor.
         * Internal: ilgili kütüphane içinde namespace içinde ulaşılabiliyor.
         * Internal Protected: uygumala içerisinden veya kalıtıldıysa ulaşılabilir.
         * 
         */

        public void OgrenciMetot1(string ogrenciAdi, string ogrenciSoyadi)
        {
            Console.WriteLine("Öğrenci Bilgileri: {0} {1}",ogrenciAdi,ogrenciSoyadi);
        }

        public void OgrenciMetot2()
        {
            OgrenciMetot1("Şule", "Celep");
        }
        
    }
}
