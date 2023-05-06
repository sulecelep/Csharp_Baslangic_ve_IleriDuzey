using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_88_DoWhile_Odev1Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Ödev 1 : Kullanıcıyı do while içine alın ve kullanıcı adı ve password sorun,
            //Kullanıcı adı :Demo Şifre: Demo eğer kullanıcı bu değerleri bilirse döngüden çıkın ve
            //başarılı yazın. Eğer yanlış giriş yapıyorsa do while ile ilgili değerleri
            //sormaya devam edin.
            string kullaniciAdi = "Demo";
            string sifre = "Demo";
            string username = "";
            string password = "";
            do
            {
                Console.Write("Kullanıcı adı: ");
                username = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Şifre:");
                password = Console.ReadLine();
                Console.Clear();

            } while (kullaniciAdi != username || password != sifre);
            Console.WriteLine("Başarılı");


        }
    }
}
