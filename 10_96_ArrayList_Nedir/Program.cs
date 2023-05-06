using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_96_ArrayList_Nedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            /*
             * 
             */

            int Capacity = 0;
            int Count = 0;
            ArrayList A1 = new ArrayList();

            #region Tek değer ekleme
            A1.Add("Şule Celep");

            Capacity = A1.Capacity; //Arraylistin kapasitesi default 4 oluyor Count artınca 4 artıyor otomatik
            Count = A1.Count;  //Count ArrayListin mevcut eleman sayısı

            //A1.Add(100);
            #endregion

            #region Birden fazla değer ekleme
            ArrayList A2 = new ArrayList();
            A2.Add("Yakut");
            A2.Add("Merve");
            A2.Add("Utkan");
            A1.AddRange(A2);  //A1 nesnesi içerisine A2'deki değerleri atadık, A1 4 karakterli oldu, A2 sabit kaldı.
            #endregion

            #region Capacity & Countİnceleme
            Capacity =A1.Capacity;
            Count =A1.Count;
            #endregion

            #region Koleksiyon içindeki değere ulaşmak ve yeni değer atamak 
            object O1 = A1[3];
            string S1 = A1[3].ToString();
            //int I1 = (int)A1[1];

            A1[1] = "Hamza";

            #endregion

            #region ArrayList Sıralama
            A1.Sort(); //Sıralar A-Z

            A1.Reverse(); //Tersten sıralar ama karşılaştırma yapmaz Z-A'ya göre değil indexe göre ters çevirir

            #endregion

            #region Koleksiyonlar yardımcı komutları
            if(A1.Contains("Yakup"))
            {
                int index = A1.IndexOf("Yakup");
                A1.Remove(index);
            }
            bool Kontrol1 = A1.Contains("Hamza");
            bool Kontrol2 = A1.Contains(100);
            int IndexDegeri=A1.IndexOf("Hamza");
            A1.ToArray(); //objeleri dizi olarak verir ToArray değil de ToList olarak kullancaz
            //ToArray yaptıktan sonra eleman eklemek yok sadece olan elemanı diziye dönüşütürür
            object[] O2= A1.ToArray();
            //A1.Clear(); // Koleksiyonun içindeki bütün değerleri siler Capacity değişmez
            //A1.TrimToSize(); //Capacity'i 4'e çekti
            
            #endregion  

            #region ArrayList Koleksiyonu İçindeki Değeri Silme

            //A1.RemoveAt(3); //3. indexi siler 
            A1.Remove("Hamza"); //indexi komple kaldırdı
           // A1.RemoveRange(2, 2);  //2. indexten başlayıp 2 index daha siler

            #endregion

            #region 5 elemanlı(string) ArrayList içindeki değerleri Z-A olacak şekilde güncelleyin
            ArrayList odev = new ArrayList();
            odev.Add("Ayşe");
            odev.Add("Zeynep");
            odev.Add("Yasemin");
            odev.Add("Atilla");
            odev.Add("Burak");

            odev.Sort(); //Index Z-A ya göre sıralamadığı için önce Sort yapıp sonra reverser yaptık
            odev.Reverse();
            #endregion
            //Objeden veri tipi alıyoruz
        }
    }
}
