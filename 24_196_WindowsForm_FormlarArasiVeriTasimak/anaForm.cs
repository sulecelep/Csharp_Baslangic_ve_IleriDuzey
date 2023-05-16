using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_196_WindowsForm_FormlarArasiVeriTasimak
{
	public partial class anaForm : Form
	{
		public anaForm(kullanici bulunanKullanici)
		{
			InitializeComponent();

			txtIsim.Text = bulunanKullanici.isim;
			txtSoyisim.Text = bulunanKullanici.soyisim;
			txtKullaniciAdi.Text = bulunanKullanici.kullaniciAdi;
			txtKullaniciAdi.Enabled = false;
			txtSifre.Text = bulunanKullanici.sifre;
			txtAciklama.Text = bulunanKullanici.aciklama;
			btnGuncelle.Tag = bulunanKullanici.id;
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			Button btnGuncelleYakala = (Button)sender;
			int id = (int)btnGuncelleYakala.Tag;
			int index= sanalDatabase.KullaniciTablo.FindIndex(i => i.id == id);
			sanalDatabase.KullaniciTablo[index].isim = txtIsim.Text;
			sanalDatabase.KullaniciTablo[index].soyisim = txtSoyisim.Text;
			sanalDatabase.KullaniciTablo[index].sifre = txtSifre.Text;
			sanalDatabase.KullaniciTablo[index].aciklama = txtAciklama.Text;
		}
	}
}
