using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_191_WindowsForm_Inceleme
{
	public partial class MerhabaForm : Form
	{
		public MerhabaForm(string metin)
		{
			InitializeComponent();
			//1. çalışan metot yapıcı metot
			//Eğer bir windows form elemanına dokunmanız gerekirse buradan ya da daha
			//asağıdan properties'den yapabilirsiniz.
			label1.Text = metin;	
		}

	}
}
