using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_125_OOP_Siniflar_Odev
{
    internal class Arac
    {
        public Arac() 
        {
        }

        public Arac(string _marka, string _model)
        {
            Marka = _marka;
            Model = _model;
        }
        public Arac(string _marka, string _model, int _modelYili)
        {
            Marka = _marka;
            Model = _model;
            ModelYili = _modelYili;
        }
        public Arac(string _marka, string _model, int _modelYili, decimal _km)
        {
            Marka = _marka;
            Model = _model;
            ModelYili = _modelYili;
            this.Km = _km;
        }
        public string Marka;
        public string Model;
        public int ModelYili;
        public decimal Km;
        public int YakitTipi;
        public int VitesTipi;
        public decimal AlisFiyati;
        public decimal SatisFiyati;
        public decimal MaxIndirimTutari;
        public decimal Fiyat;

        public void BilgileriGoruntule()
        {
            Console.WriteLine("Aracın Bilgileri: ");
            Console.WriteLine("Marka: {0}",Marka);
            Console.WriteLine("Model: {0}",Model);
            Console.WriteLine("Model Yılı: {0}",ModelYili);
            Console.WriteLine("Km: {0}",Km);
            //Console.WriteLine("Yakıt tipi: {0}",YakitTipi);
            //Console.WriteLine("Alış Fiyatı: {0}",AlisFiyati);
            //Console.WriteLine("Satış Fiyatı: {0}",SatisFiyati);
        }
        public void FiyatAta(decimal _fiyat)
        {
            if (_fiyat < SatisFiyati - MaxIndirimTutari )
            {
                Console.WriteLine("Geçersiz Fiyat Girişi");
            }
            else
            {
                this.Fiyat = _fiyat;
                Console.WriteLine("Fiyat Güncellendi");
            }
           
        }
        
    }
}
