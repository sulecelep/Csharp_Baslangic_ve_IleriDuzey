using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_227_WindowsForm_GridViewde_ImageKullanmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Urun> urunlerim= new List<Urun>(); 
            urunlerim.Add(new Urun()
            {
                Id = 1,
                UrunTanim="Kitap 1",
                ResimYol= @"C:\Users\CELEP\Desktop\Resimler_Form\metastaz.jpg"
            });
            urunlerim.Add(new Urun()
            {
                Id = 2,
                UrunTanim = "Kitap 2",
                ResimYol = @"C:\Users\CELEP\Desktop\Resimler_Form\sekerportakali.jpg"
            });
            urunlerim.Add(new Urun()
            {
                Id = 3,
                UrunTanim = "Kitap 3",
                ResimYol = @"C:\Users\CELEP\Desktop\Resimler_Form\ilberortayli.jpg"
            });
            urunlerim.Add(new Urun()
            {
                Id = 3,
                UrunTanim = "Kitap 3",
                ResimYol = string.Empty
            });
            dgwUrunler.DataSource= urunlerim;
        }
    }
}
