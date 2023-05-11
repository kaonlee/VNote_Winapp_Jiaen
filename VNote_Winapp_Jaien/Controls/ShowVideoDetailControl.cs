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
using VNote.DataLayer.YouTube;

namespace VNote_Winapp_Jaien
{
	public partial class ShowVideoDetailControl : UserControl
	{
		public ShowVideoDetailControl()
		{
			InitializeComponent();
		}
		public VideosDto VideoDto { get; private set; }

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

		public async Task LoadVideo(string url)
		{
			try
			{
				YouTubeAPIHelper youtubeHelper = new YouTubeAPIHelper("AIzaSyATjyd6HONNdL3ehIlYT8YGAYT_Vje6EgA");
				YouTubeVideo videoDetail = await youtubeHelper.GetVideoDetail(url);
				VideosDto dto = videoDetail.toVideosDto();
				VideoDto= dto;

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
				labelDuration.Text = dto.DurationFormated;
				labelVidoType.Text = (dto.IsStreamVideo) ? "直播影片" : "影片";
				labelStartedTime.Text = dto.LiveStartedAt.ToString();
				labelPublishedTime.Text=dto.PublishedAt.ToString();
				labelTitle.Text = dto.VideoTitle;
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void LoadVideo (VideosDto dto)
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
				labelDuration.Text = dto.DurationFormated;
				labelVidoType.Text = (dto.IsStreamVideo) ? "直播影片" : "影片";
				labelStartedTime.Text = $"Start: {dto.LiveStartedAt.ToString()}";
				labelPublishedTime.Text = $"Published: {dto.PublishedAt.ToString()}";
				labelTitle.Text = dto.VideoTitle;

			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void labelChannelName_Click(object sender, EventArgs e)
		{

		}

		private void labelVidoType_Click(object sender, EventArgs e)
		{

		}

		private void ShowVideoDetailControl_Load(object sender, EventArgs e)
		{

		}

		private void labelStartedTime_Click(object sender, EventArgs e)
		{

		}

		private void labelPublishedTime_Click(object sender, EventArgs e)
		{

		}

		private void labelTitle_Click(object sender, EventArgs e)
		{

		}
	}
}
