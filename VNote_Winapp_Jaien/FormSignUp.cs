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
	public partial class FormSignUp : Form
	{
		public FormSignUp()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtUserName.Text ==string.Empty || txtPassword.Text == string.Empty || txtPwCheck.Text == string.Empty) 
			{ 
				MessageBox.Show("請輸入完整再行註冊！");
				return;
			}

			if (txtPassword.Text != txtPwCheck.Text)
			{
				MessageBox.Show("請確認兩次密碼輸入相同");
				return;
			}

			IUsersRepository repo = new SqlUsersRepository();
			UsersService service = new UsersService(repo);
			try
			{
				service.Insert(txtUserName.Text, txtPassword.Text);
				MessageBox.Show("建立成功！可以開始你的 VNote 生活了！");
				this.Close();
			}
			catch(Exception ex) 
			{
				MessageBox.Show($"{ex.Message} 請再試一次！");
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
