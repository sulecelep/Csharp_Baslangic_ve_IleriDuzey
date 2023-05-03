using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_70_KararYapilari_Alistirma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı adınızı giriniz: ");
            string kullaniciAdi=Console.ReadLine();

            Console.Write("Şifrenizi giriniz: ");
            string sifre=Console.ReadLine();

            //Kullanıcı adı: admin
            //Şifre: 123
            if(kullaniciAdi=="admin" && sifre=="123")
            {
                Console.WriteLine("Tebrikler, kullanıcı girişiniz doğrulandı.");
            }
            else
            {
                Console.WriteLine("Girişiniz başarısız oldu, kullanıcı adı veya şifrenizi kontrol ediniz..");
            }
        }
    }
}
