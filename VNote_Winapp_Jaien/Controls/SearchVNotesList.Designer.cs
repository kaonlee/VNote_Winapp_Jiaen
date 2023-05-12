namespace VNote_Winapp_Jaien.Controls
{
	partial class SearchVNotesList
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.checkBoxLater = new System.Windows.Forms.CheckBox();
			this.checkBoxFav = new System.Windows.Forms.CheckBox();
			this.txtKeyword = new System.Windows.Forms.TextBox();
			this.txtTag = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Thumbnail = new System.Windows.Forms.DataGridViewImageColumn();
			this.VideoTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChannelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IsFavorite = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.IsNoteLater = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.LastEditAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThumbnailUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FormattedDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.Location = new System.Drawing.Point(692, 39);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(57, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Search !";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBoxLater
			// 
			this.checkBoxLater.AutoSize = true;
			this.checkBoxLater.Location = new System.Drawing.Point(26, 39);
			this.checkBoxLater.Name = "checkBoxLater";
			this.checkBoxLater.Size = new System.Drawing.Size(76, 17);
			this.checkBoxLater.TabIndex = 2;
			this.checkBoxLater.Text = "Note Later";
			this.checkBoxLater.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.checkBoxLater.UseVisualStyleBackColor = true;
			this.checkBoxLater.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBoxFav
			// 
			this.checkBoxFav.AutoSize = true;
			this.checkBoxFav.Location = new System.Drawing.Point(26, 16);
			this.checkBoxFav.Name = "checkBoxFav";
			this.checkBoxFav.Size = new System.Drawing.Size(78, 17);
			this.checkBoxFav.TabIndex = 2;
			this.checkBoxFav.Text = "MyFavorite";
			this.checkBoxFav.UseVisualStyleBackColor = true;
			this.checkBoxFav.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// txtKeyword
			// 
			this.txtKeyword.Location = new System.Drawing.Point(472, 42);
			this.txtKeyword.Name = "txtKeyword";
			this.txtKeyword.Size = new System.Drawing.Size(214, 20);
			this.txtKeyword.TabIndex = 3;
			// 
			// txtTag
			// 
			this.txtTag.Location = new System.Drawing.Point(223, 42);
			this.txtTag.Name = "txtTag";
			this.txtTag.Size = new System.Drawing.Size(214, 20);
			this.txtTag.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(208, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Tag";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(457, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Keyword";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thumbnail,
            this.VideoTitle,
            this.Tag,
            this.ChannelName,
            this.IsFavorite,
            this.IsNoteLater,
            this.LastEditAt,
            this.ThumbnailUrl,
            this.FormattedDuration});
			this.dataGridView1.Location = new System.Drawing.Point(13, 17);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 90;
			this.dataGridView1.Size = new System.Drawing.Size(873, 444);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
			// 
			// panel1
			// 
			this.panel1.AllowDrop = true;
			this.panel1.Controls.Add(this.txtTag);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBoxLater);
			this.panel1.Controls.Add(this.checkBoxFav);
			this.panel1.Controls.Add(this.txtKeyword);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(905, 73);
			this.panel1.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 73);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(905, 486);
			this.panel2.TabIndex = 6;
			// 
			// Thumbnail
			// 
			this.Thumbnail.HeaderText = "Thumbnail";
			this.Thumbnail.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Thumbnail.Name = "Thumbnail";
			this.Thumbnail.ReadOnly = true;
			this.Thumbnail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Thumbnail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Thumbnail.Width = 160;
			// 
			// VideoTitle
			// 
			this.VideoTitle.DataPropertyName = "VideoTitle";
			this.VideoTitle.FillWeight = 10F;
			this.VideoTitle.HeaderText = "VideoTitle";
			this.VideoTitle.Name = "VideoTitle";
			this.VideoTitle.ReadOnly = true;
			this.VideoTitle.Width = 320;
			// 
			// Tag
			// 
			this.Tag.DataPropertyName = "Tag";
			this.Tag.FillWeight = 50F;
			this.Tag.HeaderText = "Tag";
			this.Tag.Name = "Tag";
			this.Tag.ReadOnly = true;
			this.Tag.Width = 80;
			// 
			// ChannelName
			// 
			this.ChannelName.DataPropertyName = "ChannelName";
			this.ChannelName.FillWeight = 50F;
			this.ChannelName.HeaderText = "Channel";
			this.ChannelName.Name = "ChannelName";
			this.ChannelName.ReadOnly = true;
			this.ChannelName.Width = 160;
			// 
			// IsFavorite
			// 
			this.IsFavorite.DataPropertyName = "IsFavorite";
			this.IsFavorite.FillWeight = 50F;
			this.IsFavorite.HeaderText = "Favorite";
			this.IsFavorite.Name = "IsFavorite";
			this.IsFavorite.ReadOnly = true;
			this.IsFavorite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.IsFavorite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.IsFavorite.Width = 80;
			// 
			// IsNoteLater
			// 
			this.IsNoteLater.DataPropertyName = "IsNoteLater";
			this.IsNoteLater.FillWeight = 50F;
			this.IsNoteLater.HeaderText = "Note Later";
			this.IsNoteLater.Name = "IsNoteLater";
			this.IsNoteLater.ReadOnly = true;
			this.IsNoteLater.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.IsNoteLater.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.IsNoteLater.Width = 80;
			// 
			// LastEditAt
			// 
			this.LastEditAt.DataPropertyName = "LastEditAt";
			this.LastEditAt.FillWeight = 50F;
			this.LastEditAt.HeaderText = "Last Edit At";
			this.LastEditAt.Name = "LastEditAt";
			this.LastEditAt.ReadOnly = true;
			this.LastEditAt.Width = 80;
			// 
			// ThumbnailUrl
			// 
			this.ThumbnailUrl.DataPropertyName = "ThumbnailUrl";
			this.ThumbnailUrl.FillWeight = 50F;
			this.ThumbnailUrl.HeaderText = "Thumbnail Url";
			this.ThumbnailUrl.Name = "ThumbnailUrl";
			this.ThumbnailUrl.ReadOnly = true;
			// 
			// FormattedDuration
			// 
			this.FormattedDuration.DataPropertyName = "FormattedDuration";
			this.FormattedDuration.HeaderText = "Duration";
			this.FormattedDuration.Name = "FormattedDuration";
			this.FormattedDuration.ReadOnly = true;
			this.FormattedDuration.Width = 80;
			// 
			// SearchVNotesList
			// 
			this.AllowDrop = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "SearchVNotesList";
			this.Size = new System.Drawing.Size(905, 559);
			this.Load += new System.EventHandler(this.SearchVNotesList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBoxLater;
		private System.Windows.Forms.CheckBox checkBoxFav;
		private System.Windows.Forms.TextBox txtKeyword;
		private System.Windows.Forms.TextBox txtTag;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridViewImageColumn Thumbnail;
		private System.Windows.Forms.DataGridViewTextBoxColumn VideoTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChannelName;
		private System.Windows.Forms.DataGridViewCheckBoxColumn IsFavorite;
		private System.Windows.Forms.DataGridViewCheckBoxColumn IsNoteLater;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastEditAt;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThumbnailUrl;
		private System.Windows.Forms.DataGridViewTextBoxColumn FormattedDuration;
	}
}
