using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_99_Koleksiyonlar_HashTable_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hashtable içerisine ingilizce türkçe olarak data eklemeniz.
            /*
             * Yeni kayıt eklemek istiyor musunuz E/H
             * E : Yeni kayıt ekleme işlemi devam etsin
             * H : Tüm listeyi yazdırın.
             * 
             * Var olan bir key değeri ekliyorsa kullanıcıya bu değer daha önceden
             * ... şeklinde sistemimizde bulunmaktadır.
             */

            Console.WriteLine("İngilizce - Türkçe Sözlüğe Hoş Geldiniz.");
            string secim=String.Empty;
            string ing=String.Empty;
            string tur=String.Empty;
            string tur1=String.Empty;
            Hashtable hashtable = new Hashtable();
            do
            {
                Console.Clear();
                Console.Write("Girmek istediğiniz İngilizce kelime: ");
                ing= Console.ReadLine().ToLower();
                System.Threading.Thread.Sleep(2000);
                if(hashtable.ContainsKey(ing))
                {
                    hashtable[ing] = tur1;
                    Console.WriteLine("{0} değeri daha önceden {1} şeklinde sistemimizde bulunmaktadır.",ing,tur1);
                }
                else
                {
                    Console.Clear();

                    Console.Write("{0} kelimesinin Türkçe karşılığı: ", ing);
                    tur = Console.ReadLine().ToLower();
                    hashtable.Add(ing,tur);
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("{0} kelimesinin karşılığı {1} olacak şekilde sözlüğe eklenmiştir", ing, tur);
                    Console.Clear();
                }
                Console.WriteLine("Yeni kayıt eklemek istiyor musunuz E/H");

            } while (Console.ReadLine().ToUpper() != "H");

            //1. YONTEM
            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine("ENG : {0} = {1} : TR", item, hashtable[item]);
            }

            //2. YONTEM
            foreach (DictionaryEntry item in hashtable)
            {
                //Console.WriteLine(item.GetType().Name);
                Console.WriteLine("ENG : {0} = {1} : TR", item.Key,item.Value);

            }
        }
    }
}
