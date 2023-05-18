using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_200_WindowsForm_MessageBox_NotificationKontrolleri_Uygulama
{
    public class Musteri
    {
        public Guid id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        public string telefonNumarasi { get; set; }

        public override string ToString()
        {
            return isim + " " + soyisim;
        }
    }
}
