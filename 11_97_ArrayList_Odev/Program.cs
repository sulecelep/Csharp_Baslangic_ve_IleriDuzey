using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_97_ArrayList_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList degerListesi = new ArrayList();
            string secim= String.Empty;
            do
            {
                Console.Clear();
                Console.WriteLine("Menü");
                Console.WriteLine("1- Değer Ekle");
                Console.WriteLine("2- Değer Listele");
                Console.WriteLine("3- Değer Ara");
                Console.WriteLine("4- Değer Düzenle");
                Console.WriteLine("5- Değer Sil");
                Console.WriteLine("6- Uygulama Çıkış");
                Console.Write("Seçiniz: ");
                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Eklemek istediğiniz değeri giriniz: ");
                        string eklenenDeger= Console.ReadLine();
                        degerListesi.Add(eklenenDeger);
                        Console.WriteLine("Değer başarılı bir şekilde eklendi.");
                        System.Threading.Thread.Sleep(2000); //Ekranın beklemesini sağlar 1000 yazarsak 1 sn olur milisaniye cinsindendir
                        break;
                    case "2":
                        for(int i=0; i<degerListesi.Count; i++)
                        {
                            Console.WriteLine("{0}. Değer = {1}", i, degerListesi[i]);
                        }
                        Console.WriteLine("Devam etmek için bir tuşa basınız");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Aramak istediğiniz değeri giriniz: ");
                        string arananDeger=Console.ReadLine();
                        bool kontrol = degerListesi.Contains(arananDeger);
                        if(kontrol)
                        {
                            int arananIndex=degerListesi.IndexOf(arananDeger);
                            string bulunanDeger = degerListesi[arananIndex].ToString();
                            Console.WriteLine("Değeriniz bulundu: index sırası: {0} - Değer: {1} ",arananIndex,bulunanDeger);
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız değer bulunamadı..");
                            // Eğer aradığı kriterde değer bulamadı ise kullanıcıya bu değeri listeye ekleyelim mi olarak sorun eger kullanıcı E derse listeye ekleyin. 

                        }
                        System.Threading.Thread.Sleep(2000);

                        break;
                    case "4":
                        Console.WriteLine("Düzenlemek istediğiniz değeri giriniz: ");
                        string duzenlenenDeger = Console.ReadLine();
                        if(degerListesi.Contains(duzenlenenDeger))
                        {
                            int duzenlenenIndex = degerListesi.IndexOf(duzenlenenDeger);
                            Console.WriteLine("Yeni değeri giriniz: ");
                            string yeniDeger = Console.ReadLine();
                            degerListesi[duzenlenenIndex] = yeniDeger;
                        }
                        else
                        {
                            Console.WriteLine("Düzenlemek istediğiniz değer bulunamadı"); 
                        }

                        System.Threading.Thread.Sleep(2000);

                        break;
                    case "5":
                        Console.WriteLine("Tüm değerleri mi silmek istiyorsunuz (E/H): ");
                        string cevap= Console.ReadLine();
                        if(cevap.ToUpper()=="E")
                        {
                            degerListesi.Clear();
                            Console.WriteLine("Tüm değerler silindi.");
                        }
                        else
                        {
                            Console.WriteLine("Silmek istediğiniz değeri giriniz: ");
                            string silinenDeger = Console.ReadLine();
                            if (degerListesi.Contains(silinenDeger))
                            {
                                int silinenIndex = degerListesi.IndexOf(silinenDeger);
                                degerListesi.RemoveAt(silinenIndex);
                            }
                            else
                            {
                                Console.WriteLine("Silmek istediğiniz değer bulunamadı.");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Lütfen menüden geçerli bir işlem seçiniz.");
                        break;
                }
            } while (secim != "6");
            Console.ReadLine();
        }
    }
}
