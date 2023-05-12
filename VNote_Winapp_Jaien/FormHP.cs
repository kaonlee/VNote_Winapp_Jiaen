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

		public void LoadForm(Form form)
		{
			if (currentForm != null)
			{
				currentForm.Close();
			}

			currentForm = form;
			currentForm.TopLevel = false;
			currentForm.FormBorderStyle = FormBorderStyle.None;
			currentForm.Dock = DockStyle.Fill;
			currentForm.Anchor = AnchorStyles.Top | AnchorStyles.Left;
			panelMain.Controls.Add(currentForm);
			currentForm.Show();
		}

		private void btnNewVNote_Click(object sender, EventArgs e)
		{
			FormAddVNote formAddVNote = new FormAddVNote();
			formAddVNote.ParentForm = this;
			LoadForm(formAddVNote);
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

		private void panelTop_Paint(object sender, PaintEventArgs e)
		{

		}

		private void FormHP_Load(object sender, EventArgs e)
		{

			if (FormLogin.userId == 1)
			{
				button1.Visible = true;
				button1.Enabled = true;
			}
			else
			{
				button1.Visible = false;
				button1.Enabled = false;
			}

			FormWelcome formWelcome = new FormWelcome();
			formWelcome.ParentForm = this;
			LoadForm(formWelcome);
		}

		private void btnVNotesList_Click(object sender, EventArgs e)
		{
			FormReadVNotes formeadVNotes = new FormReadVNotes();
			formeadVNotes.ParentForm = this;
			LoadForm(formeadVNotes);
		}

		private void btnNoteLatter_Click(object sender, EventArgs e)
		{
			FormReadVNotes formeadVNotes = new FormReadVNotes(true);
			formeadVNotes.ParentForm = this;
			LoadForm(formeadVNotes);
		}

		private void btnFavorite_Click(object sender, EventArgs e)
		{
			FormReadVNotes formeadVNotes = new FormReadVNotes(false,true);
			formeadVNotes.ParentForm = this;
			LoadForm(formeadVNotes);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			var frm = new FormEditAccount(FormLogin.userId);
			frm.ShowDialog();
		}

		private void btnLogOut_Click_1(object sender, EventArgs e)
		{
			isLoggingOut = true;
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormEditAccounts formEditAccounts = new FormEditAccounts();
			formEditAccounts.ParentForm = this;
			LoadForm(formEditAccounts);
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			FormWelcome formWelcome = new FormWelcome();
			formWelcome.ParentForm = this;
			LoadForm(formWelcome);
		}
	}
}
