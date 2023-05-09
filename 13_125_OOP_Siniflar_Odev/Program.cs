using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_125_OOP_Siniflar_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖDEV
            /*
             * Araç Nesnesi
             * Marka
             * Model
             * ModelYıl
             * KM
             * Yakıt Tipi
             * Vites Tipi
             * Alis Fiyati
             * SatisFiyati
             * MaxIndirimTutar
             * Fiyat
             * 
             * Marka Model
             * Marka Model Yıl 
             * Marka Model Yıl KM
             * 
             * Void BilgileriGoruntule();
             * Void FiyatAta();
             *
             */

            Arac A1 = new Arac("Opel","Corsa",2010,56000);
            A1.AlisFiyati = 28000;
            A1.SatisFiyati = 32000;
            A1.MaxIndirimTutari = 1500;
            //A1.Fiyat=  //Kapsülleme kousu
            A1.FiyatAta(30000);
            A1.BilgileriGoruntule();

        }
    }
}
