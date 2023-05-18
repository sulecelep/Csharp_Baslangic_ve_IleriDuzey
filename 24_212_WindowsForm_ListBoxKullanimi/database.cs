using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_212_WindowsForm_ListBoxKullanimi
{
    public class database
    {
        public static List<urun> UrunTablo = new List<urun>()
        {
            new urun(){id=1,urunAdi ="Bir Ömür Nasıl Yaşanır?",stokMiktar=10, urunKategori="Roman", yazar="İlber Ortaylı", urunResim=@"C:\Users\CELEP\Desktop\Resimler_Form\ilberortayli.jpg" ,urunDetay=@"“Bir Ömür Nasıl Yaşanır?”, ülkemizin medarıiftiharı olmuş bir tarihçinin gözünden, insanın hayattaki anlam arayışına, bu arayışın tadını nasıl çıkaracağına ve süreç boyunca karşılaşacağı zorluklarla nasıl baş etmesi gerektiğine dair çok özel bir kılavuz…"},
            new urun(){id=2,urunAdi ="Metastaz",stokMiktar=10, urunKategori="Roman", yazar="Barış Pehlivan Terkoğlu", urunResim=@"C:\Users\CELEP\Desktop\Resimler_Form\metastaz.jpg" ,urunDetay=@"İlk kez yazılan gerçeklerle tabular yıkılıyor...Barış Pehlivan ve Barış Terkoğlu, METASTAZ ile devleti esir alan kanserli hücrelere ışık tutuyor."},
            new urun(){id=3,urunAdi ="Şeker Portakalı",stokMiktar=10, urunKategori="Roman", yazar="Jose Mauro De Vasconcelos", urunResim=@"C:\Users\CELEP\Desktop\Resimler_Form\sekerportakali.jpg" ,urunDetay=@"Brezilya edebiyatının klasiklerinden Şeker Portakalı, José Mauro de Vasconcelos’un başyapıtı kabul edilir. Yetişkinler dünyasının sınırlamalarına hayal gücüyle meydan okuyan Zezé’nin yoksulluk, acı ve ümit dolu hikâyesi yazarın çocukluğundan derin izler taşır. Beş yaşındaki Zezé hemen her şeyi tek başına öğrenir: sadece bilye oynamayı ve arabalara asılmayı değil, okumayı ve sokak şarkıcılarının ezgilerini de. En yakın sırdaşıysa, anlattıklarına kulak veren ve Minguinho adını verdiği bir şeker portakalı fidanıdır…"},
        };
    }
}
