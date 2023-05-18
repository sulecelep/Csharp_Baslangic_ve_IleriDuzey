using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_217_WindowsForm_CheckedBoxListKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedBoxListDoldurV1();
        }
        private void checkedBoxListDoldurV1()
        {
            foreach (var item in database.UrunTablo)
            {
                chkListBox.Items.Add(item);
            }
        }

        private void chkListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = (CheckedListBox)sender;
            if(e.NewValue == CheckState.Checked)
            {
                urun secilenUrun = checkedListBox.Items[e.Index] as urun;
                pctUrunResim.Image = Image.FromFile(secilenUrun.urunResim);
                pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;
                txtUrunAdi.Text = secilenUrun.urunAdi;
                txtKategori.Text = secilenUrun.urunKategori;
                txtStokMiktari.Text = secilenUrun.stokMiktar.ToString();
                txtYazar.Text = secilenUrun.yazar;
                rtxtUrunDetay.Text = secilenUrun.urunDetay;
            }
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if(i==e.Index)
                {

                }
                else
                {
                    chkListBox.SetItemChecked(i, false);
                }
            }

        }
    }
}
