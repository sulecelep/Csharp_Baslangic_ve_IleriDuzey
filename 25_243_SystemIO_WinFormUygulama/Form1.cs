using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_243_SystemIO_WinFormUygulama
{
    public partial class Form1 : Form
    {
        DataIslemleri dataIslemleri;
        List<Personel> personelListe;
        public Form1()
        {
            InitializeComponent();
            dataIslemleri = new DataIslemleri(); //garbage collectorde silinmemesi için yapıldı
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            personelListe = dataIslemleri.personelGetir(150);
            lstPersonel.DataSource = personelListe;
        }

        private void lstPersonel_DoubleClick(object sender, EventArgs e)
        {
            Personel secilenPersonel=lstPersonel.SelectedItem as Personel;
            txtIsım.Text = secilenPersonel.isim;
            txtSoyisim.Text=secilenPersonel.soyisim;
            txtEmailAdres.Text = secilenPersonel.emailAdres;
            txtFirma.Text = secilenPersonel.firmaAdi;
            txtUlke.Text=secilenPersonel.ulke;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            dataIslemleri.PersonelKaydet("c:\\Users\\CELEP\\Udemy",personelListe);
        }
    }
}
