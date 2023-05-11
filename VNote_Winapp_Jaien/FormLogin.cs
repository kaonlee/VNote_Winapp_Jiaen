using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VNote.DataLayer.Infra.SqlRepository;
using VNote.DataLayer.Interface;
using VNote.DataLayer.Service;

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
			IUsersRepository repo = new SqlUsersRepository();
			UsersService service = new UsersService(repo);
			if(!service.Exist(txtUserName.Text, txtPassword.Text))
			{
				MessageBox.Show("名稱或密碼錯誤，請確認後再試一次"); 
				return;
			}

			userId = service.GetUserId(txtUserName.Text); // 用 username 去 get
			var frm = new FormHP();
			frm.Owner = this;
			this.Hide();

			frm.ShowDialog();
			txtPassword.Text = string.Empty;
			this.Show();
		}

		private void btnSignUp_Click(object sender, EventArgs e)
		{
			var frm = new FormSignUp();
			frm.ShowDialog();
		}
	}
}
