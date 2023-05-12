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

namespace VNote_Winapp_Jaien.Controls
{
	public partial class FormEditAccounts : Form
	{
		public FormEditAccounts()
		{
			InitializeComponent();
		}
		public FormHP ParentForm { get; set; }
		private List<UsersDto> _users;
		private void FormEditAccounts_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return; // 如果點到Header，不要理他

			int userId = _users[e.RowIndex].UserId;
			var frm = new FormEditAccount(userId);
			frm.ShowDialog();
			frm.Owner = this;
			Display();
		}

		public void Display()
		{
			IUsersRepository repo = new SqlUsersRepository();
		UsersService service = new UsersService(repo);
		List<UsersDto> users = service.GetAll();
		_users = users;
			dataGridView1.DataSource = _users;
			// 隱藏不需要顯示的欄位
			dataGridView1.Columns["Password"].Visible = false;
			dataGridView1.Columns["UserId"].Visible = false;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Display();
		}
	}
}
