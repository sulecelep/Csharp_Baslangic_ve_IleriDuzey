using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_98_Koleksiyonlar_HashTable_Nedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            //Generic'te Dictionary olarak geçiyor
            Hashtable H1 =new Hashtable();
            //H1.Add("benzersiz key","bu değerin karşılığı")
            #region Yeni değer ekleme
            H1.Add("Car", "Araba");
            H1.Add("House", "Ev");

            // H1.Add("Car", "Arabalar"); //daha önceden Car keyiyle bir değer eklediğimimz için hata verdi
            #endregion

            #region Yardımcı metotlar

            //Contains Key ve Contains aynı işlemi yapar key'i içerip içermediğine bakar
            bool kontrol= H1.Contains("Car"); 
            bool kontrol1 = H1.Contains("Houses");
            bool kontrol2 = H1.ContainsKey("House");

            //ContainsValue değer var mı yok mu diye bakar
            bool kontrol4 = H1.ContainsValue("Araba");

            H1["House"] = "Villa"; //Güncelleme 
            H1.Remove("Car");
            
            int koleksiyonToplam = H1.Count;
            //H1.Clear(); //koleksiyon içerisindeki tüm datayı temizler

            
            #endregion
        }
    }
}
