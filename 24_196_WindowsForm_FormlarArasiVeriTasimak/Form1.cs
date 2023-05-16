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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void btnGirisYap_Click(object sender, EventArgs e)
		{
			string kullaniciAdi=txtKullaniciAdi.Text;
			string sifre = txtSifre.Text;

			kullanici bulunanKullanici= sanalDatabase.KullaniciTablo.Find(i=>i.kullaniciAdi==kullaniciAdi && i.sifre==sifre);	
			if(bulunanKullanici != null)
			{
				anaForm _anaForm = new anaForm(bulunanKullanici);
				_anaForm.Show();
			}
			else
			{
				//windows form içerisinde kullanıcıya popup nasıl gösteririz
				//ayrı bir konu olarak inceleyeceğiz 
				MessageBox.Show("Hatalı kullanıcı bilgileri","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void txtKullaniciAdi_Enter(object sender, EventArgs e)
		{
			TextBox T1 = (TextBox)sender;
			T1.BackColor = Color.Yellow;
		}

		private void txtKullaniciAdi_Leave(object sender, EventArgs e)
		{
			TextBox T1 = (TextBox)sender;
			T1.BackColor = Color.White;
		}

		private void txtSifre_Enter(object sender, EventArgs e)
		{
			TextBox T1 = (TextBox)sender;
			T1.BackColor = Color.Yellow;
		}

		private void txtSifre_Leave(object sender, EventArgs e)
		{
			TextBox T1 = (TextBox)sender;
			T1.BackColor = Color.White;
		}

	}
}
