using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VNote.DataLayer.DTOs;

namespace VNote_Winapp_Jaien.Controls
{
	public partial class ShowVideoDetailatVNote : UserControl
	{
		public ShowVideoDetailatVNote()
		{
			InitializeComponent();
		}
		private VideosDto _dto;

		private void ShowVideoDetailatVNote_Load(object sender, EventArgs e)
		{

		}

		public void LoadVideo(VideosDto dto)
		{
			try
			{
				try
				{
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(dto.ThumbnailUrl);
					HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
					Stream stream = httpWebReponse.GetResponseStream();

					// 將圖像加載到圖片框中
					pictureBox.Image = Image.FromStream(stream);
					httpWebReponse.Close();
				}
				catch (Exception ex)
				{
					// 處理錯誤
					MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				labelChannelName.Text = dto.ChannelName;
				labelPublishedTime.Text = dto.PublishedAt.ToString();
				labelTitle.Text = dto.VideoTitle;

			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			_dto = dto;
		}

		private string WrapText(string text, int maxLineWidth, Font font)
		{
			var wrappedText = new StringBuilder();
			var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			var spaceWidth = TextRenderer.MeasureText(" ", font).Width;

			int lineWidth = 0;
			foreach (var word in words)
			{
				var wordWidth = TextRenderer.MeasureText(word, font).Width;

				if (lineWidth + wordWidth > maxLineWidth)
				{
					wrappedText.AppendLine();
					lineWidth = 0;
				}

				wrappedText.Append(word + " ");
				lineWidth += wordWidth + spaceWidth;
			}

			return wrappedText.ToString().TrimEnd();
		}

		private void btnWatch_Click(object sender, EventArgs e)
		{
			string url = $"https://www.youtube.com/watch?v={_dto.VideoId}";
			Process.Start(url);
		}

		private void labelPublishedTime_Click ( object sender, EventArgs e )
		{

		}

		private void labelChannelName_Click ( object sender, EventArgs e )
		{

		}
	}
}
