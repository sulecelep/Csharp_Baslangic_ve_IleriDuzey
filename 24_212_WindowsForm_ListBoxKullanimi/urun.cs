using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_212_WindowsForm_ListBoxKullanimi
{
    public class urun
    {
        public int id { get; set; }
        public string urunResim { get; set; }
        public string urunAdi { get; set; }
        public string urunKategori { get; set; }
        public int stokMiktar { get; set; }
        public string yazar { get; set; }
        public string urunDetay { get; set; }

        public override string ToString()
        {
            return urunAdi;
        }
    }
}
