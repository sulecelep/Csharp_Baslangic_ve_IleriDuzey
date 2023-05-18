using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_221_WindowsForm_FakeDataKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string isim=FakeData.NameData.GetFirstName();
            //string soyisim=FakeData.NameData.GetSurname();
            //MessageBox.Show(isim + " " + soyisim,"Fake Data Inceleme",MessageBoxButtons.OK);
            database db = new database();
            List<musteri> musteriListe = db.musteriListele();
        }
    }
}
