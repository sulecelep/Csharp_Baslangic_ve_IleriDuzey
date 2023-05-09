using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_123_OOP_Siniflar_YapiciMetotKullanimi
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
            TCKimliknumara=tckimlikno;
        }

        public Musteri(string tckimlikno, string _isim)
        {
            TCKimliknumara = tckimlikno;
            isim = _isim;
        }

        public Musteri(string _tckimlikno, string _isim, string _soyisim )
        {
            TCKimliknumara=_tckimlikno;
            isim = _isim;
            soyisim = _soyisim;
        }

        public string TCKimliknumara;
        public string isim;
        public string soyisim;
        public int cinsiyet;   //717770001 : Bay - 717770002 : Bayan

    }
}
