using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_206_WindowsForm_CalismaZamanindaNesneOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblSkor.Text = "0";
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            int mayin1 = 0;
            int mayin2 = 0;
            int mayin3 = 0;

            Random rnd = new Random();
            mayin1 = rnd.Next(1, 20);
            mayin2 = rnd.Next(21, 40);
            mayin3 = rnd.Next(41, 50);

            for (int i = 1; i <= 50; i++)
            {
                Button btnTemp = new Button();
                btnTemp.Name = "btn" + i.ToString();
                btnTemp.Size = new System.Drawing.Size(35, 35);
                btnTemp.Text = i.ToString();
                btnTemp.UseVisualStyleBackColor = true;
                if(mayin1==i || mayin2 ==i || mayin3==i)
                {
                    btnTemp.Tag = true;
                }
                else
                {
                    btnTemp.Tag = false;
                }
                btnTemp.Click += BtnTemp_Click;
                flowLayoutPanel1.Controls.Add(btnTemp);
            }
        }

        private void BtnTemp_Click(object sender, EventArgs e)
        {
            // eğer 3 kez mayına basıldıysa form üzerinde bulunan tüm butonları pasif edin
            // ve uygulama bitti şeklinde bir mesaj versin.
            Button basilanButon = (Button)sender;
            bool mayinBulunduMu = (bool)basilanButon.Tag;
            
            if(mayinBulunduMu)
            {
               
                    MessageBox.Show("Mayını buldunuz tebrikler");
                    basilanButon.BackColor = Color.Red;
                    int mayinInt = int.Parse(lblMayin.Text);
                    mayinInt++;
                    lblMayin.Text = mayinInt.ToString();
                    
            }
            else
            {
                basilanButon.BackColor= Color.Green;
                int skorInt = int.Parse(lblSkor.Text);
                skorInt++;
                lblSkor.Text = skorInt.ToString(); 
            }
            
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

//this.btnUret.Location = new System.Drawing.Point(470, 12);
//this.btnUret.Name = "btnUret";
//this.btnUret.Size = new System.Drawing.Size(114, 97);
//this.btnUret.TabIndex = 0;
//this.btnUret.Text = "Üret";
//this.btnUret.UseVisualStyleBackColor = true;
//this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
