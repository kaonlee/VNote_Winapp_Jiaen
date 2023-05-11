using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VNote.DataLayer.DTOs;
using VNote.DataLayer.Infra.SqlRepository;
using VNote.DataLayer.Interface;
using VNote.DataLayer.Service;

namespace VNote_Winapp_Jaien.Controls
{
	public partial class ShowVNoteControl : UserControl
	{
		public ShowVNoteControl()
		{
			InitializeComponent();
		}
		private UserVideoNotesDto _dto;


		private void ShowVNoteControl_Load(object sender, EventArgs e)
		{

		}

		private void checkBoxFavorite_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBoxNoteLatter_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void labelTag_Click(object sender, EventArgs e)
		{

		}

		public void LoadNote(UserVideoNotesDto dto)
		{
			try
			{
				txtNote.Text = dto.Note;
				txtTag.Text = dto.Tag;
				labelLastEditedat.Text = dto.LastEditAt.Value.ToString("yyyy-MM-dd HH-mm");
				
				checkBoxFavorite.Checked = dto.IsFavorite;
				checkBoxNoteLatter.Checked = dto.IsNoteLater;

				_dto = dto;
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			UserVideoNotesEditDto updateNoteDto = new UserVideoNotesEditDto()
			{
				UserVideoNoteID = _dto.UserVideoNoteId,
				VideoId = _dto.VideoId,
				Note = txtNote.Text,
				Tag = txtTag.Text,
				LastEditAt = _dto.LastEditAt,
				IsFavorite = checkBoxFavorite.Checked,
				IsNoteLater = checkBoxNoteLatter.Checked
			};
			IUserVideoNotesRepository repo = new SqlUserVideoNotesRepository();
			UserVideoNotesService service = new UserVideoNotesService(repo);
			try
			{
				service.Update(updateNoteDto);
				MessageBox.Show("完成更新！");
				labelLastEditedat.Text = DateTime.Now.ToString("yyyy-MM-dd HH-mm");

			}
			catch (Exception ex)
			{ 
				MessageBox.Show(ex.Message);
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			IUserVideoNotesRepository repo = new SqlUserVideoNotesRepository();
			UserVideoNotesService service = new UserVideoNotesService(repo);
			DialogResult result = MessageBox.Show("確定要刪除這筆VNote?", "完成刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				try
				{
					service.Delete(_dto.UserVideoNoteId);
					MessageBox.Show("Data deletion completed");
					Form form = this.FindForm();
					form.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Unable to delete!!!");
				}
			}
			//回到首頁

		}
	}
}
