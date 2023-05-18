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

            // 1.Data bize lazım ama ekranda görünsün istemiyoruz, bu gibi durumlarda
            // Columns koleksiyonu içinde ilgili kolonun id değeri veya prop adı verilerek
            // visible prop false edilmesi yeterlidir.
            dgwMusteriListe.DataSource = musteriListe;
            //dgwMusteriListe.Columns[0].Visible = false; //column indexiyle görünmez yaptık
            dgwMusteriListe.Columns["id"].Visible = false; //column adıyla görünmez yaptık

            //Data Grid View içerisinde bulunan kolonların isimlerini değiştirmek
            dgwMusteriListe.Columns[0].HeaderText = "Müşteri ID";
            dgwMusteriListe.Columns[1].HeaderText = "İsim";
            dgwMusteriListe.Columns[2].HeaderText = "Soyisim";
            dgwMusteriListe.Columns[3].HeaderText = "Tam Adı";
            dgwMusteriListe.Columns[4].HeaderText = "Email Adres";
            dgwMusteriListe.Columns[5].HeaderText = "Telefon";
            dgwMusteriListe.Columns[6].HeaderText = "Şehir";
            dgwMusteriListe.Columns[7].HeaderText = "Ülke";
            dgwMusteriListe.Columns[8].HeaderText = "Açık Adres";
            dgwMusteriListe.Columns[8].Width = 500;


            //2. Data bize lazım değil hiçbir şekilde ekranda görünmesini veya kullanmak istemiyoruz.
            //var dgwListe = from I in musteriListe
            //               select new
            //               {
            //                   isim = I.isim,
            //                   soyisim = I.soyisim,
            //                   tamAdi = I.tamAdi
            //               };
            //dgwMusteriListe.DataSource = dgwListe.ToList();
        }

        private void dgwMusteriListe_DoubleClick(object sender, EventArgs e)
        {
            int musteriID = (int)dgwMusteriListe[0,dgwMusteriListe.CurrentCell.RowIndex].Value;

            database db = new database();
            musteri bulunanMusteri= db.musteriListele().FindAll(i=> i.id ==musteriID).FirstOrDefault();

            popupMesaj popup = new popupMesaj(bulunanMusteri);
            popup.Show();
        }
    }
}
