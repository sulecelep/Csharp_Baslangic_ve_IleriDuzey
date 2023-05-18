using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_230_SystemIO_DosyaKlasorIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //YeniKlasorOlustur(@"C:\Users\CELEP\Desktop\Udemy");
            //KlasorVarlikKontrolu(@"C:\Users\CELEP\Desktop\Udemy");
            //KlasorSilmeIslemleri(@"C:\Users\CELEP\Desktop\Udemy");
            //Odev1(@"C:\Users\CELEP\Desktop\Udemy");
            OdevI();
        }
        static void YeniKlasorOlustur(string path)
        {
            DirectoryInfo DI= Directory.CreateDirectory(path);
        }
        static void KlasorVarlikKontrolu(string path)
        {
            bool kontrol=Directory.Exists(path);
        }
        static void KlasorSilmeIslemleri(string path)
        {
            Directory.Delete(path,true); //recursive: true içinde dosya varsa da sileyim mi sorusuna evet diyor 
        }
        static bool KlasorVarlikKontroluOdev(string path)
        {
            bool kontrol = Directory.Exists(path);
            return kontrol;
        }

        static void Odev1(string path)
        {
            /*
             * C sürücüsü içerisinde Udemy adında bir klasör oluşturun.
             * Öncesinde varlık kontrolü yapın var ise silin sonra oluşturun
             * Eğer klasör yok ise yine oluşturun ama bu adımların isimlerini ekrana yazdırın
             * Örn; Klasör var silindi, yeni klasör oluşturuldu gibi...
             * 
             */
            if(KlasorVarlikKontroluOdev(path))
            {
                KlasorSilmeIslemleri(path);
                YeniKlasorOlustur(path);
                Console.WriteLine("Udemy adındaki var olan klasör silindi, Udemy klasörü yeniden oluşturuldu");
            }
            else
            {
                YeniKlasorOlustur(path);
                Console.WriteLine("Udemy klasörü oluşturuldu");

            }

        }
        static void OdevI()
        {

            /*
             * C sürücüsü içerisinde Udemy adında bir klasör oluşturun oluşturmadan önce varlık kontorlü yapın eğer klasor var ise silin daha sonra oluşturun 
             * eğer klasor yok ise oluşturun fakat bu adımların bilgisini ekrana yazdırın .
             */

            string dosyaYol = @"C:\Users\CELEP\Desktop\Udemy";
            bool kontrol = Directory.Exists(dosyaYol);
            if (kontrol)
            {
                Console.WriteLine("Eklemek istediğiniz klasör sistemde mevcut");
                Console.Write("Silmek ve yerine yeni olarak oluşturmak istiyor musunuz [E/H]");
                string cevap = Console.ReadLine().ToUpper();
                if (cevap == "E")
                {
                    Directory.Delete(dosyaYol, true);
                    Console.WriteLine("Dosya silme işlemi tamamlandı");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine(dosyaYol + " sisteminize oluşturuluyor");
                    Directory.CreateDirectory(dosyaYol);
                }
                else
                {
                    Console.WriteLine("İşlem Bitti");
                }

            }
            else
            {
                DirectoryInfo DI = Directory.CreateDirectory(dosyaYol);
                if (DI.Exists)
                {
                    Console.WriteLine("Dosya sistemde oluşturuldu");
                }
            }

        }
    }
}
