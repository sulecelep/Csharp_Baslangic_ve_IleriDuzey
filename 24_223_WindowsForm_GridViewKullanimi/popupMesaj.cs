using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_223_WindowsForm_GridViewKullanimi
{
    public partial class popupMesaj : Form
    {
        musteri musteriData;
        public popupMesaj(musteri data)
        {
            InitializeComponent();
            musteriData = data;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popupMesaj_Load(object sender, EventArgs e)
        {
            txtIsim.Text = musteriData.isim;
            txtSoyisim.Text=musteriData.soyisim;
            txtTamAd.Text = musteriData.tamAdi;
            txtEmail.Text = musteriData.emailAdres;
            txtIlUlke.Text = $"{musteriData.il} / {musteriData.ulke}";
            txtTelefon.Text = musteriData.telefonNumara;
            txtAdres.Text = musteriData.adres;
        }
    }
}
