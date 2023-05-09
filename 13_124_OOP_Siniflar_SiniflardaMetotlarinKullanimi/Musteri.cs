using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_124_OOP_Siniflar_SiniflardaMetotlarinKullanimi
{
    internal class Musteri
    {
        /*
       * Yapıcı Metotlar
       * defaut değerleri burada belirtiriz.
       * 
       */
        public Musteri()
        {
            //TCKimliknumara = "11111111111";
            //isim = "Şule";
            //soyisim = "Celep";
            //cinsiyet = 717770002;

        }
        public Musteri(string tckimlikno)
        {
            TCKimliknumara = tckimlikno;
        }

        public Musteri(string tckimlikno, string _isim)
        {
            TCKimliknumara = tckimlikno;
            isim = _isim;
        }

        public Musteri(string _tckimlikno, string _isim, string _soyisim)
        {
            TCKimliknumara = _tckimlikno;
            isim = _isim;
            soyisim = _soyisim;
        }

        public string TCKimliknumara;
        public string isim;
        public string soyisim;
        public int cinsiyet;   //717770001 : Bay - 717770002 : Bayan


        public bool MusteriKontrol()
        {
            //database'e gidilir müşterinin tcsine göre daha önce kaydedilip
            //kaydedilmemesi kontrol edilir
            bool kontrol = MusteriKontrolDatabase(TCKimliknumara);
            return kontrol;

        }
        internal bool MusteriKontrolDatabase(string _tckimlikno)  //namespace içindeki herke bu metoda ulaşabilir.
        {
            return true;
        }
    }
}
