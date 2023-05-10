using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VNote.DataLayer;
using VNote.DataLayer.Infra.MemoryRepository;
using VNote.DataLayer.Interface;

namespace VNote_Winapp_Jaien
{
	public partial class SearchVideoList : UserControl
	{
		public SearchVideoList()
		{
			InitializeComponent();
		}

		public void Display()
		{
			var repo = new MemoryVideoRepository();
			var criteria = new VideoSearchCriteria() { Keyword = this.txtKeyword.Text };
			var datasource = repo.Search(criteria).ToList();


			// 新增圖片欄位
			var thumbnailColumn = new DataGridViewImageColumn();
			thumbnailColumn.HeaderText = "Thumbnail";
			thumbnailColumn.Name = "Thumbnail";
			thumbnailColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // 設定圖片填充方式
			dataGridView1.RowTemplate.Height = 90; // 設定行高
			thumbnailColumn.Width = 160; // 設定列寬
			dataGridView1.Columns.Add(thumbnailColumn);

			// 設定 DataSource
			dataGridView1.DataSource = datasource;

			// 讀取並處理數據
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				// 取得圖片 URL
				var url = row.Cells["ThumbnailUrl"].Value.ToString();

				// 讀取圖片並顯示在圖片欄位中
				if (!string.IsNullOrEmpty(url))
				{
					try
					{
						var client = new WebClient();
						var stream = client.OpenRead(url);
						var image = Image.FromStream(stream);
						row.Cells["Thumbnail"].Value = image;
						stream.Flush();
						stream.Close();
					}
					catch (Exception ex)
					{
						// 如果讀取失敗則顯示錯誤訊息
						MessageBox.Show("Error: " + ex.Message);
					}
				}
			}
			// 移除圖片 URL 欄位
			dataGridView1.Columns.Remove("ThumbnailUrl");
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Display();
		}


		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{

		}

	}
}
