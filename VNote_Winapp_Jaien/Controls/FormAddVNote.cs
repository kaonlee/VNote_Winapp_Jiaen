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
	public partial class FormAddVNote : Form
	{
		public FormAddVNote()
		{
			InitializeComponent();
		}
		public FormHP ParentForm { get; set; }

		private VideosDto thisvideoDto=null;

		private async void btnChek_Click(object sender, EventArgs e)
		{
			string url = txtUrl.Text;
			await showVideoDetailControl1.LoadVideo(url);
			thisvideoDto = showVideoDetailControl1.VideoDto;
			showVideoDetailControl1.Visible = ( thisvideoDto == null ) ? false : true;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			IVideosRepositiry videorepo = new SqlVideosRepository();
			VideosService videoservice = new VideosService(videorepo);
			IUserVideoNotesRepository uservnoterepo = new SqlUserVideoNotesRepository();
			UserVideoNotesService userVNoteService = new UserVideoNotesService(uservnoterepo);
			if (thisvideoDto == null)
			{
				MessageBox.Show("請先確實查詢到再加入！");
				return;
			}

			int noteId = 0;
			if (videoservice.Exists(thisvideoDto.VideoId))
			{
				if (userVNoteService.Exists(thisvideoDto.VideoId, FormLogin.userId))
				{
					MessageBox.Show("早就建了，幫你打開");
					noteId = userVNoteService.GerNoteId(thisvideoDto.VideoId, FormLogin.userId);
					ParentForm.LoadForm(new FormReadEditVNote(noteId));
				}
				else
				{
					noteId = userVNoteService.Create(thisvideoDto.VideoId, FormLogin.userId);
					MessageBox.Show($"完成建立你的 VNote!");
					ParentForm.LoadForm(new FormReadEditVNote(noteId));
				}
			}
			else
			{
				videoservice.Create(thisvideoDto);
				noteId = userVNoteService.Create(thisvideoDto.VideoId, FormLogin.userId);
				MessageBox.Show($"完成建立你的 VNote!");
				ParentForm.LoadForm(new FormReadEditVNote(noteId));
			}
		}

		private void FormAddVNote_Load(object sender, EventArgs e)
		{
			
		}


	}
}
