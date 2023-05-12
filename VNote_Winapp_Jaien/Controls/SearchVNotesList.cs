using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VNote.DataLayer.DTOs;
using VNote.DataLayer.Infra.MemoryRepository;
using VNote.DataLayer.Infra.SqlRepository;
using VNote.DataLayer.Interface;
using VNote.DataLayer.Service;

namespace VNote_Winapp_Jaien.Controls
{
	public partial class SearchVNotesList : UserControl
	{
		public SearchVNotesList()
		{
			InitializeComponent();
		}
		private List<UserVideoNotesDto> _notes;

		private UserVideoNoteSearchCriteria _criteria;
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void SearchVNotesList_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		public async void LoadList(UserVideoNoteSearchCriteria criteria)
		{
			_criteria = criteria;
			Display();
			await LoadImageAsync();
			dataGridView1.Refresh();

			txtKeyword.Text = criteria.Keyword;
			txtTag.Text = criteria.Tag;
			checkBoxFav.Checked = criteria.IsFavorite??false;
			checkBoxLater.Checked = criteria.IsNoteLater??false;
		}

		public void Display()
		{
			IUserVideoNotesRepository repo = new SqlUserVideoNotesRepository();
			UserVideoNotesService service = new UserVideoNotesService(repo);
			var result = service.Serarch(_criteria);
			_notes = result.ToList();
			_notes = _notes.OrderByDescending(n => n.LastEditAt).ToList();

			//設定 DataSource
			dataGridView1.DataSource = _notes;

			// 隱藏不需要顯示的欄位
			dataGridView1.Columns["VideoId"].Visible = false;
			dataGridView1.Columns["UserId"].Visible = false;
			dataGridView1.Columns["UserVideoNoteId"].Visible = false;
			dataGridView1.Columns["ThumbnailUrl"].Visible = false;
			dataGridView1.Columns["LiveStartedAt"].Visible = false;

			// 設定顯示順序
			dataGridView1.Columns["Thumbnail"].DisplayIndex = 0;
			dataGridView1.Columns["VideoTitle"].DisplayIndex = 1;
			dataGridView1.Columns["ChannelName"].DisplayIndex = 2;
			dataGridView1.Columns["IsFavorite"].DisplayIndex = 3;
			dataGridView1.Columns["IsNoteLater"].DisplayIndex = 4;
			dataGridView1.Columns["Tag"].DisplayIndex = 5;
			dataGridView1.Columns["ThumbnailUrl"].DisplayIndex = 6;
			dataGridView1.Columns["FormattedDuration"].DisplayIndex = 7;
			dataGridView1.Columns["LastEditAt"].DisplayIndex = 8;

		}

		private async Task LoadImageAsync()
		{
			List<Image> images = new List<Image>();
			// 讀取並處理數據
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				// 取得圖片 URL
				var url = ((UserVideoNotesDto)row.DataBoundItem).ThumbnailUrl;

				if (!string.IsNullOrEmpty(url))
				{
					try
					{
						using (var client = new WebClient())
						{
							var stream = await client.OpenReadTaskAsync(url);
							var image = Image.FromStream(stream);
							images.Add(image);
							stream.Flush();
							stream.Close();
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message);
					}
				}
				else
				{
					images.Add(null); // 如果 URL 為空，則添加一個空值到圖像列表中
				}
			}
			// 分配圖像列
			var thumbnailColumnIndex = dataGridView1.Columns["Thumbnail"].Index;
			for (int i = 0; i < dataGridView1.Rows.Count; i++)
			{
				dataGridView1.Rows[i].Cells[thumbnailColumnIndex].Value = images[i];
			}
			dataGridView1.Columns.Remove("ThumbnailUrl");
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private async void button1_Click(object sender, EventArgs e)
		{
			UserVideoNoteSearchCriteria newcriteria = new UserVideoNoteSearchCriteria()
			{
				Keyword = txtKeyword.Text,
				Tag = txtTag.Text,
				IsFavorite = checkBoxFav.Checked ? true : (bool?)null,
				IsNoteLater = checkBoxLater.Checked ? true : (bool?)null,
				UserId = FormLogin.userId
			};

			_criteria = newcriteria;
			Display();
			await LoadImageAsync();
		}

		private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex < 0) return; // 如果點到Header，不要理他

			int noteid = _notes[e.RowIndex].UserVideoNoteId;
			FormReadVNotes formReadVNotes = this.ParentForm as FormReadVNotes;
			if (formReadVNotes != null)
			{
				FormHP frmHP = formReadVNotes.ParentForm as FormHP;
				if (frmHP != null)
				{
					frmHP.LoadForm(new FormReadEditVNote(noteid));
				}
			}
		}

		private void panel1_Paint ( object sender, PaintEventArgs e )
		{

		}

		private void OrderTitle_Click ( object sender, EventArgs e )
		{
		}
	}
}
