using System;
using System.Windows.Forms;

namespace _24_202_WindowsForm_FormControllere_Nasil_Ulasilir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button => this.Controls.Add(); // control tipi
            //foreach(Control item in this.Controls)
            //{
            //    MessageBox.Show(item.Name);
            //}
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Form üzerindeki alanları temizlemek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //formTemizle();
                formElemanIndexTemizle();
            }
            else if (res == DialogResult.No)
            {

            }
        }
        private void formElemanIndexTemizle()
        {
            ((TextBox)this.Controls["txtIsim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtSoyisim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtEmailAdres"]).Text = string.Empty;
            ((TextBox)this.Controls["txtTelefon"]).Text = string.Empty;
        }
        private void formTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) //true dönerse item control == TextBox
                {
                    TextBox T = (TextBox)item;
                    T.Text = string.Empty;
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // sanal database içerisine kayıt işlemi (ödev)
            Musteri musteri = new Musteri()
            {
                isim = txtIsim.Text,
                soyisim = txtSoyisim.Text,
                emailAdres = txtEmailAdres.Text,
                telefon = txtTelefon.Text
            };

            sanalDatabase.musteriler.Add(musteri);


            formTemizle();
        }

        private void btnOnizleme_Click(object sender, EventArgs e)
        {
            frmOnizlemeKayit onizlemeKayit = new frmOnizlemeKayit();
            ((TextBox)onizlemeKayit.Controls["txtIsimOnizleme"]).Text = txtIsim.Text;
            ((TextBox)onizlemeKayit.Controls["txtSoyisimOnizleme"]).Text = txtSoyisim.Text;
            ((TextBox)onizlemeKayit.Controls["txtEmailAdresOnizleme"]).Text = txtEmailAdres.Text;
            ((TextBox)onizlemeKayit.Controls["txtTelefonOnizleme"]).Text = txtTelefon.Text;
            onizlemeKayit.ShowDialog();

        }
    }
}
