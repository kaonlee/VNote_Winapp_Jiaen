using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VNote_Winapp_Jaien
{
	public partial class FormLogin : Form
	{
		public static int userId {  get; set; }
		public FormLogin()
		{
			InitializeComponent();
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			userId = 1; // 用 username 去 get
			var frm = new FormHP();
			frm.Owner = this;
			this.Hide();

			frm.ShowDialog();
			this.Show();
		}
	}
}
