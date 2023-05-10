namespace VNote_Winapp_Jaien
{
	partial class SearchYTVideoUrl
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
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lIsStreamVideo = new System.Windows.Forms.Label();
			this.lDurationFormat = new System.Windows.Forms.Label();
			this.lLiveStartedAt = new System.Windows.Forms.Label();
			this.lChannelName = new System.Windows.Forms.Label();
			this.lVideoTitle = new System.Windows.Forms.Label();
			this.picThumbler = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picThumbler)).BeginInit();
			this.SuspendLayout();
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(66, 83);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(298, 27);
			this.txtUrl.TabIndex = 0;
			this.txtUrl.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lIsStreamVideo);
			this.groupBox1.Controls.Add(this.lDurationFormat);
			this.groupBox1.Controls.Add(this.lLiveStartedAt);
			this.groupBox1.Controls.Add(this.lChannelName);
			this.groupBox1.Controls.Add(this.lVideoTitle);
			this.groupBox1.Controls.Add(this.picThumbler);
			this.groupBox1.Location = new System.Drawing.Point(42, 138);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(707, 364);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// lIsStreamVideo
			// 
			this.lIsStreamVideo.AutoSize = true;
			this.lIsStreamVideo.Location = new System.Drawing.Point(343, 87);
			this.lIsStreamVideo.Name = "lIsStreamVideo";
			this.lIsStreamVideo.Size = new System.Drawing.Size(53, 20);
			this.lIsStreamVideo.TabIndex = 1;
			this.lIsStreamVideo.Text = "label1";
			this.lIsStreamVideo.Click += new System.EventHandler(this.txtVideoTitle_Click);
			// 
			// lDurationFormat
			// 
			this.lDurationFormat.AutoSize = true;
			this.lDurationFormat.Location = new System.Drawing.Point(19, 234);
			this.lDurationFormat.Name = "lDurationFormat";
			this.lDurationFormat.Size = new System.Drawing.Size(53, 20);
			this.lDurationFormat.TabIndex = 1;
			this.lDurationFormat.Text = "label1";
			this.lDurationFormat.Click += new System.EventHandler(this.txtVideoTitle_Click);
			// 
			// lLiveStartedAt
			// 
			this.lLiveStartedAt.AutoSize = true;
			this.lLiveStartedAt.Location = new System.Drawing.Point(343, 247);
			this.lLiveStartedAt.Name = "lLiveStartedAt";
			this.lLiveStartedAt.Size = new System.Drawing.Size(53, 20);
			this.lLiveStartedAt.TabIndex = 1;
			this.lLiveStartedAt.Text = "label1";
			this.lLiveStartedAt.Click += new System.EventHandler(this.txtVideoTitle_Click);
			// 
			// lChannelName
			// 
			this.lChannelName.AutoSize = true;
			this.lChannelName.Location = new System.Drawing.Point(343, 117);
			this.lChannelName.Name = "lChannelName";
			this.lChannelName.Size = new System.Drawing.Size(53, 20);
			this.lChannelName.TabIndex = 1;
			this.lChannelName.Text = "label1";
			this.lChannelName.Click += new System.EventHandler(this.txtVideoTitle_Click);
			// 
			// lVideoTitle
			// 
			this.lVideoTitle.AutoSize = true;
			this.lVideoTitle.Location = new System.Drawing.Point(343, 163);
			this.lVideoTitle.Name = "lVideoTitle";
			this.lVideoTitle.Size = new System.Drawing.Size(53, 20);
			this.lVideoTitle.TabIndex = 1;
			this.lVideoTitle.Text = "label1";
			this.lVideoTitle.Click += new System.EventHandler(this.txtVideoTitle_Click);
			// 
			// picThumbler
			// 
			this.picThumbler.Location = new System.Drawing.Point(6, 87);
			this.picThumbler.Name = "picThumbler";
			this.picThumbler.Size = new System.Drawing.Size(320, 180);
			this.picThumbler.TabIndex = 0;
			this.picThumbler.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(390, 83);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 25);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SearchYTVideoUrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtUrl);
			this.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "SearchYTVideoUrl";
			this.Size = new System.Drawing.Size(800, 600);
			this.Load += new System.EventHandler(this.SearchYTVideoUrl_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picThumbler)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox picThumbler;
		private System.Windows.Forms.Label lVideoTitle;
		private System.Windows.Forms.Label lIsStreamVideo;
		private System.Windows.Forms.Label lLiveStartedAt;
		private System.Windows.Forms.Label lChannelName;
		private System.Windows.Forms.Label lDurationFormat;
		private System.Windows.Forms.Button button1;
	}
}
