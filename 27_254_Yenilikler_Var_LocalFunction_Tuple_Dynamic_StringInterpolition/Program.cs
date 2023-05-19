using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _27_254_Yenilikler_Var_LocalFunction_Tuple_Dynamic_StringInterpolition
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Local Function Kullanımı
            //int Toplam = Topla(12, 13);
            //Console.WriteLine(Toplam);

            //int Carp(int sayi1, int sayi2) //Main metodunun içerisinde int dönen bir metot oluşturabildik
            //{
            //    return sayi1 * sayi2;
            //}
            //int Carpim= Carp(10, 3);
            //Console.WriteLine(Carpim);  
            #endregion

            #region String Interpolition
            //string isim = "Cengiz";
            //string soyisim = "Cengiz";
            //Console.WriteLine("Merhaba " + isim + " " + soyisim);
            //string karsilamaMetin = string.Format("Merhaba {0} {1}", isim, soyisim); //indexer
            //Console.WriteLine(karsilamaMetin);

            ////Yenilik
            //Console.WriteLine($"Merhaba {isim} {soyisim}"); //string interpolition
            #endregion

            #region Var anahtar kelimesi
            //string isimsoyisim = "Cengiz Atilla";
            //Console.WriteLine(isimsoyisim);

            //var meslek = "Bilgisayar Programcısı";
            //meslek.ToString();

            #endregion

            #region İsimsiz Tip Kullanımı
            //Musteri m = new Musteri();
            //m.isim = "Cengiz";
            //m.soyisim = "Atilla";


            //var Ogrenci = new  //sadece get edilebilir atama yapılamaz
            //{
            //    numara = 1,
            //    isim="Cengiz",
            //    soyisim="Atilla"
            //};

            #endregion

            #region Metoda default parametre atamak
            //int carpim = Carp(3);

            #endregion

            #region Try Catch When Kullanımı
            //try
            //{
            //    //...kodlarımız
            //    throw new FormatException("Format Hatası");
            //}
            //catch(FieldAccessException fex)
            //{
            //    Console.WriteLine(fex.Message);
            //}
            //catch(FormatException fx) when(fx.Message=="Format Hatası")
            //{
            //    Console.WriteLine(fx.Message);
            //}
            //catch(FormatException fx)
            //{
            //    Console.WriteLine(fx.Message);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            #endregion

            #region Auto Property

            //Araba A1 = new Araba();
            //A1.Plaka = "34 ABC 123";
            //A1.Marka = "BMW";

            #endregion

            #region Tuple Kullanımı
            // bazen tip kullanmak istemeyiz metottan birden fazla tipte parametre isteyebiliriz
            // Tuple kullanıyoruz

            //Tuple<string, string, int, bool, Araba, string,string> tupleKullanimi = new Tuple<string, string, int, bool, Araba, string,string>
            //    ("Cengiz","Atilla",1,true,new Araba() { Marka="BMW" },"Istanbul","Türkiye");

            //Console.WriteLine(tupleKullanimi.Item1); 

            //Tuple<string,string> selamlama= Selamla();
            //Console.WriteLine(selamlama.Item1);
            //Console.WriteLine(selamlama.Item2);

            //var selamlama2 = Selamla2();  //okunaklı tuple
            //Console.WriteLine(selamlama2.isim + " " + selamlama2.soyisim); 
            #endregion

            #region Dynamic
            //var deger1 = "Cengiz";
            //deger1 =1;
            //var ile farkı var atanan ilk değerin tipini benimseyip diğer atamalarda farklı tiplerde atama yapıl
            //masına izin vermiyordu
            //dynamic ise bir sonraki değere göre tipini değiştirebiliyor.

            //dynamic deger2 = "Cengiz Atilla"; 
            //deger2 = 12;
            //deger2 = true;

            #endregion

        }

        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        static int CarpEski(int sayi1, int sayi2)
        {
            if (sayi2 == 0) sayi2 = 1;
            return (sayi1 * sayi2);
        }
        //Yenilik
        static int Carp(int sayi1, int sayi2=1)
        {
            return (sayi1 * sayi2);
        }
        static Tuple<string,string> Selamla()
        {
            return new Tuple<string, string>("Cengiz", "Atilla");
        }
        static (string isim, string soyisim) Selamla2()
        {
            return ("Cengiz", "Atilla");
        }
    }
}
