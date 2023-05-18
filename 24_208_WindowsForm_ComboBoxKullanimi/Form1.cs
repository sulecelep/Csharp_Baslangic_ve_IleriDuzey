using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_208_WindowsForm_ComboBoxKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Items.Add metodu kullanılarak değerer combobox'a eklendi
            //comboBoxDoldurV1();
            comboBoxDoldurV2();
        }
        void comboBoxDoldurV2()
        {
            cbUrunListesi.DataSource = database.UrunTablo;
        }
        void comboBoxDoldurV1()
        {
            foreach (var item in database.UrunTablo)
            {
                cbUrunListesi.Items.Add(item);
            }
        }

        private void cbUrunListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. yöntem 
            object o1= cbUrunListesi.SelectedItem;
            urun u1 = (urun)o1;

            //u1 = cbUrunListesi.SelectedItem == null ? null: cbUrunListesi.SelectedItem as urun;

            // 2. yöntem

            //ComboBox secilenComboBox=sender as ComboBox;

            //1. yöntem eğer form içerisinde bulunan form elemanına özel bir metot yazıldıysa 
            //o zaman ilgili form elemanını direkt olarak çağırmak daha mantıklıdır.
            //2. yöntem çalışma zamanında oluşturmuş olduğumuz form elemanlarından hangisine tıklandığını
            //ve metodumuz birden fazla form elemanında olay metodu tanımlandığı için sender üzerinden
            //gelen nesneyi kullanır kullanıcının hangi windows form elemanında işlem apmış olduğunu anlarız.

            pctUrunResim.Image = Image.FromFile(u1.urunResim);
            pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;

            txtUrunAdi.Text = u1.urunAdi;
            txtKategori.Text = u1.urunKategori;
            txtStokMiktari.Text = u1.stokMiktar.ToString();
            txtYazar.Text = u1.yazar;
            rtxtUrunDetay.Text = u1.urunDetay;
        }
    }
}
