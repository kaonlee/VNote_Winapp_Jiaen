using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VNote_Winapp_Jaien.Controls
{
	public partial class FormWelcome : Form
	{
		public FormWelcome()
		{
			InitializeComponent();
		}
		public FormHP ParentForm
		{
			get; set;
		}
		private void FormWelcome_Load(object sender, EventArgs e)
		{

		}
	}
}
