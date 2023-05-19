using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_248_TryCatch_Finally_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MerhabaHataYonetimi();
            HataYonetimiInceleme();
        }

        static void HataYonetimiInceleme()
        {
            try
            {
                //standart uygulama için yazmış olduğumuz kod blokları
                Console.Write("Bir sayı girişi yapınız: ");
                int sayi1 = int.Parse(Console.ReadLine());

                if(sayi1==10)
                {
                    throw new OzelHataSinifi(); //Hata fırlattık catch'e gidecek bu sınıftan türeteceğiz 
                    //eğer catch'te OzelHataSinifi'ne özgü bir yakalam oluşturmasaydık, en base olan
                    //exception'a gidip herhangi bir hata alındı diye dönüş yapılacaktı.
                }
            }
            catch(OzelHataSinifi fx)
            {
                Console.WriteLine("Özel hata sınıfı catch içerisinde yakalandı.");
                Console.WriteLine(fx);
            }
            catch(FormatException fx) //Format türündeki exceptionları alır
            {
                Console.WriteLine("Sizden beklenen değer sayısal bir değerdir.");
                Console.WriteLine(fx.Message);
            }
            catch (Exception ex) //Alacak olan bütün exceptionlar var
            {
                //Catch blokları sistem içerisinde çalışma zamanında alınan hataların loglanmasına
                //ve kullanıcıya daha açıklayıcı hata mesajları vermemize yarayan bloklardır
                Console.WriteLine("Herhangi bir hata oluştu."); 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Try kısmında bizim kodumuz çalışır, hata alınca catch kısmına düşer
                //Catch => ....
                //Finally => Kod tarafında herhangi bir hata almasakta finally kısmı çalışmaya devam eder 
                //Finally Catch'e düşünce kodun devamında bazı işlemler yarıda kalıyorsa onları kapatacağımız bölümdür
                Console.WriteLine("Finally blogu çalıştı");
            }
            Console.WriteLine("Uygulama Bitti.");
            Console.ReadLine();
        }
        static void MerhabaHataYonetimi()
        {
            Console.Write("Bir sayı girişi yapınız: ");
            int sayi1 = int.Parse(Console.ReadLine());
        }
    }
}
