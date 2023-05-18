using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_227_WindowsForm_GridViewde_ImageKullanmak
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunTanim { get; set; }
        public string ResimYol { get; set; }
        public Image UrunResimYolu 
        { 
            get
            {
                if (!string.IsNullOrEmpty(ResimYol))
                {
                    return Image.FromFile(ResimYol);
                }
                else
                {
                    return Image.FromFile(@"C:\Users\CELEP\Desktop\Resimler_Form\metastaz.jpg");

                }
            } 

        }
    }
}
