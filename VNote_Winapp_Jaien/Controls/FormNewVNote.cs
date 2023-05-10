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
	public partial class FormNewVNote : Form
	{
		public FormNewVNote()
		{
			InitializeComponent();
		}
		VideosDto thisvideoDto;
		private async void button1_Click(object sender, EventArgs e)
		{
			string url = txtUrl.Text;
			await showVideoDetailControl1.LoadVideo(url);
			thisvideoDto = showVideoDetailControl1.VideoDto;
		}

		private void btnAddVideo_Click(object sender, EventArgs e)
		{
			IVideosRepositiry videorepo = new SqlVideosRepository();
			VideosService videoservice = new VideosService(videorepo);
			IUserVideoNotesRepository uservnoterepo = new SqlUserVideoNotesRepository();
			UserVideoNotesService userVNoteService = new UserVideoNotesService(uservnoterepo);
			if (videoservice.Exists(thisvideoDto.VideoId))
			{
				if (userVNoteService.Exists(thisvideoDto.VideoId, FormLogin.userId))
				{
					MessageBox.Show("早就建了，幫你打開");
				}
				else
				{
					int noteId = userVNoteService.Create(thisvideoDto.VideoId, FormLogin.userId);
					MessageBox.Show($"幫你建好了VNote, ID={noteId}");
				}
			}
			else
			{
				videoservice.Create(thisvideoDto);
				int noteId = userVNoteService.Create(thisvideoDto.VideoId, FormLogin.userId);
				MessageBox.Show($"幫你建好了VNote, ID={noteId}");
			}

		}
	}
}
