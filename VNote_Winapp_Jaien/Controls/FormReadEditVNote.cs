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
	public partial class FormReadEditVNote : Form
	{
		private int _vnoteId;
		public FormReadEditVNote(int vnoteId)
		{
			InitializeComponent();
			_vnoteId = vnoteId;	
		}

		private async void FormReadEditVNote_Load(object sender, EventArgs e)
		{
			IUserVideoNotesRepository repo = new SqlUserVideoNotesRepository();
			IVideosRepositiry videorepo = new SqlVideosRepository();
			UserVideoNotesService service = new UserVideoNotesService(repo,videorepo);
			VideosDto thisVideosDto = service.GetVideosDto(_vnoteId);
			UserVideoNotesDto thisNoteDto = service.Get(_vnoteId);
			showVideoDetailatVNote1.LoadVideo(thisVideosDto);
			showVNoteControl1.LoadNote(thisNoteDto);

		}

		private void showVideoDetailatVNote1_Load(object sender, EventArgs e)
		{

		}

		private void showVNoteControl1_Load(object sender, EventArgs e)
		{

		}
	}
}
