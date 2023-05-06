using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_93_Dizi_OrnekKullanimlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Uyg 1 : int veri tipinde bir dizi oluşturalım, kullanıcımız dizinin kaç elemanlı olacağı bilgisini bize versin, ve dizi içindeki alanlara değer ataması yapsın.

            //Console.Write("Dizi kaç elemanlı olsun: ");
            //int elemanSayisi = Convert.ToInt32(Console.ReadLine());

            //Console.Clear();
            //int[] dizi = new int[elemanSayisi];


            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.Write("{0}. indexi giriniz: ",i);
            //    int deger = Convert.ToInt32(Console.ReadLine());
            //    dizi[i] = deger;
            //}

            //Console.WriteLine("Tebrikler dizi doldu! ");
            //Console.WriteLine("Dizinin içindeki değerler ve toplam, ortalama değeri aşağıdaki gibidir: ");

            //int toplam = 0;
            //double ortalama = 0;
            //foreach(var item in dizi)
            //{
            //    Console.WriteLine(item);
            //    toplam += item;
            //}
            //Console.WriteLine("+--------------------------------------");

            //Console.WriteLine(toplam);
            //Console.WriteLine("Dizinin içerisindeki eleman sayısı : {0}",dizi.Length);
            //ortalama = toplam / dizi.Length;
            //Console.WriteLine(ortalama);


            #endregion

            #region Uyg 2 : 20 elemanlı int dizi oluşturalım. Değerlerimizi random sınıfının next fonksiyonu ile 1-10 arasındaki değerler ile dolduralım. Daha sonra dizi içerisindeki elemanlarımızı ekrana yazdıralım ve ilgili dizi içerisinde kaç tane 4 değeri old. bulalım
            Random random = new Random();

            int[] array = new int[20];
            for(int i=0; i<array.Length; i++)
            {
                int uretSayi=random.Next(1,10);
                array[i] = uretSayi; 
            }
            int sayac = 0;
            Console.Write("Array dizisi elemanları : ");

            foreach (var item in array)
            {
                Console.Write(item+" ");

                if(item==4)
                {
                    sayac++;
                }
            }
            Console.WriteLine("\nDizide toplam {0} adet 4 sayısı vardır", sayac);

            Console.ReadLine();
            #endregion

            #region

            #endregion

            #region

            #endregion

            #region

            #endregion
        }
    }
}
