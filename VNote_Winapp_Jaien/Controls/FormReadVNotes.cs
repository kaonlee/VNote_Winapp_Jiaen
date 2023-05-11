using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VNote.DataLayer.Interface;

namespace VNote_Winapp_Jaien.Controls
{
	public partial class FormReadVNotes : Form
	{
		private UserVideoNoteSearchCriteria criteria = new UserVideoNoteSearchCriteria();
		public FormReadVNotes(bool IsNotelater = false, bool IsFavo = false)
		{
			InitializeComponent();
			if (IsNotelater) 
			{
				criteria = new UserVideoNoteSearchCriteria() { UserId = FormLogin.userId, IsNoteLater = true };
			}else if (IsFavo)
			{
				criteria = new UserVideoNoteSearchCriteria() { UserId = FormLogin.userId, IsFavorite = true };
			}
			else
			{ 
				criteria = new UserVideoNoteSearchCriteria() { UserId = FormLogin.userId };
			}
		}
		public FormHP ParentForm { get; set; }

		private void FormReadVNotes_Load(object sender, EventArgs e)
		{
			searchVNotesList1.LoadList(criteria);
		}
	}
}
