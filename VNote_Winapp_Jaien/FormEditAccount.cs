using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VNote.DataLayer.DTOs;
using VNote.DataLayer.Infra.SqlRepository;
using VNote.DataLayer.Interface;
using VNote.DataLayer.Service;

namespace VNote_Winapp_Jaien
{
	public partial class FormEditAccount : Form
	{
		private int _userId;

		public FormEditAccount(int userId)
		{
			InitializeComponent();
			_userId = userId;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtUserName.Text == string.Empty || txtPassword.Text == string.Empty || txtPwCheck.Text == string.Empty)
			{
				MessageBox.Show("請輸入完整再行註冊！");
				return;
			}

			if (txtPassword.Text != txtPwCheck.Text)
			{
				MessageBox.Show("請確認兩次密碼輸入相同");
				return;
			}

			IUsersRepository usersRepository = new SqlUsersRepository();
			UsersService service = new UsersService(usersRepository);

			try
			{
				UsersDto newDto = new UsersDto()
				{
					Password = txtPassword.Text,
					UserId = _userId,
					UserName = txtUserName.Text,
				};
				service.Update(newDto);
				MessageBox.Show("完成修改！");

			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void FormEditAccount_Load(object sender, EventArgs e)
		{
			IUsersRepository usersRepository = new SqlUsersRepository();
			UsersService service = new UsersService(usersRepository);
			UsersDto dto = service.Get(_userId);
			txtUserName.Text = dto.UserName;
		}

		private void txtUserName_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
