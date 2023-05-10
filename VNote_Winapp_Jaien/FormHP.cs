using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VNote_Winapp_Jaien.Controls;

namespace VNote_Winapp_Jaien
{
	public partial class FormHP : Form
	{
		private Form currentForm;
		private bool isLoggingOut = false;

		public FormHP()
		{
			InitializeComponent();
		}

		private void LoadForm(Form form)
		{
			if (currentForm != null)
			{
				currentForm.Close();
			}

			currentForm = form;
			currentForm.TopLevel = false;
			currentForm.FormBorderStyle = FormBorderStyle.None;
			currentForm.Dock = DockStyle.Fill;
			currentForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panelMain.Controls.Add(currentForm);
			currentForm.Show();
		}

		private void btnNewVNote_Click(object sender, EventArgs e)
		{
			LoadForm(new FormNewVNote());
		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			isLoggingOut = true;
			this.Close();
		}

		private void FormHP_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!isLoggingOut && e.CloseReason == CloseReason.UserClosing)
			{
				// 如果是使用者點擊 FormHP 的關閉按鈕，並且沒有按下登出按鈕，則關閉整個應用程式
				Application.Exit();
			}
		}
	}
}
