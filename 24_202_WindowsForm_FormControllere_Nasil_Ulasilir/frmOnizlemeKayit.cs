using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_202_WindowsForm_FormControllere_Nasil_Ulasilir
{
    public partial class frmOnizlemeKayit : Form
    {
        public frmOnizlemeKayit()
        {
            InitializeComponent();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                //Form yakalananForm = Application.OpenForms["Form1"];
                //((TextBox)yakalananForm.Controls["txtIsimOnizleme"]).Text = string.Empty;
                if(item.Name =="Form1")
                {
                    foreach (Control FormItem in item.Controls)
                    {
                        if(FormItem is TextBox)
                        {
                            ((TextBox)FormItem).Text =string.Empty;
                        }
                    }
                }
            }
            this.Close();
        }
    }
}
