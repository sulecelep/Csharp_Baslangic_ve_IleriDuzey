using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_212_WindowsForm_ListBoxKullanimi
{
    public partial class urunSecimKullanici : Form
    {
        urun[] urunListe;
        public urunSecimKullanici(urun[] secilenUrunler)
        {
            InitializeComponent();
            urunListe=secilenUrunler;
        }

        private void urunSecimKullanici_Load(object sender, EventArgs e)
        {
            foreach(var item in urunListe)
            {
                Button btn = new Button();
                btn.Text = item.urunAdi;
                btn.Name = "btn" + item.id.ToString();
                btn.Size = new System.Drawing.Size(122, 37);
                btn.Tag = item;
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
           
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            urun u1 = btn.Tag as urun;

            Form F1 =Application.OpenForms["Form1"]; //açık olan formu buldum
            GroupBox F1GBOX=F1.Controls["groupBox1"] as GroupBox;
            ((PictureBox)F1GBOX.Controls["pctUrunResim"]).Image = Image.FromFile(u1.urunResim);
            ((TextBox)F1GBOX.Controls["txtUrunAdi"]).Text = u1.urunAdi;
            ((TextBox)F1GBOX.Controls["txtKategori"]).Text = u1.urunKategori;
            ((TextBox)F1GBOX.Controls["txtStokMiktari"]).Text = u1.stokMiktar.ToString();
            ((RichTextBox)F1GBOX.Controls["rtxtUrunDetay"]).Text = u1.urunDetay;
            ((TextBox)F1GBOX.Controls["txtYazar"]).Text = u1.yazar;
            this.Close();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {

        }
    }
}
