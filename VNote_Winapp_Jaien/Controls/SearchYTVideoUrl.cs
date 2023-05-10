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
using System.Security.Permissions;


namespace VNote_Winapp_Jaien
{
	public partial class SearchYTVideoUrl : UserControl
	{

		public SearchYTVideoUrl()
		{
			InitializeComponent();
		}

		private void txtVideoTitle_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_Enter(object sender, EventArgs e)
		{


		}

		private async void button1_Click(object sender, EventArgs e)
		{
			try
			{
				YouTubeAPIHelper youtubeHelper = new YouTubeAPIHelper("AIzaSyATjyd6HONNdL3ehIlYT8YGAYT_Vje6EgA"); 
				YouTubeVideo videoDetail = await youtubeHelper.GetVideoDetail(txtUrl.Text);
				VideosDto dto = videoDetail.toVideosDto();

				try
				{
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(dto.ThumbnailUrl);
					HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
					Stream stream = httpWebReponse.GetResponseStream();

					// 將圖像加載到圖片框中
					picThumbler.Image = Image.FromStream(stream);
					httpWebReponse.Close();
				}
				catch (Exception ex)
				{
					// 處理錯誤
					MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				lChannelName.Text = dto.ChannelName;
				lDurationFormat.Text = dto.DurationFormated;
				lIsStreamVideo.Text = (dto.IsStreamVideo) ? "直播影片" : "影片";
				lLiveStartedAt.Text = dto.LiveStartedAt.ToString();
				lVideoTitle.Text = dto.VideoTitle;

			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SearchYTVideoUrl_Load(object sender, EventArgs e)
		{

		}
	}
}
