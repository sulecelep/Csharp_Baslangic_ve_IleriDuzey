using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_201_WindowsForm_Show_ShowDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            MusteriKayit musteriKayit = new MusteriKayit();
            musteriKayit.Show();    
            //yeni form oluşturmak için kullanılır birden fazla kez tıklanabilir veya kullanıcı
            //form açıkken uygulamanı diğer menülerine erişebilir
        }

        private void btnGosterPopup_Click(object sender, EventArgs e)
        {
            MusteriKayit musteriKayit = new MusteriKayit();
            musteriKayit.ShowDialog();
            // ShowDialog metodunda ise sadece tek bir formda kalmak zorundayız diğer sekmelere bakamıyoruz
        }
    }
}
