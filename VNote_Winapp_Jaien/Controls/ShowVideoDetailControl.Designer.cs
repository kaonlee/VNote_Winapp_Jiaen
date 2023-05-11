namespace VNote_Winapp_Jaien
{
	partial class ShowVideoDetailControl
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
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelDuration = new System.Windows.Forms.Label();
			this.labelStartedTime = new System.Windows.Forms.Label();
			this.labelChannelName = new System.Windows.Forms.Label();
			this.labelVidoType = new System.Windows.Forms.Label();
			this.labelPublishedTime = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(26, 37);
			this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTitle.MaximumSize = new System.Drawing.Size(200, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(54, 28);
			this.labelTitle.TabIndex = 1;
			this.labelTitle.Text = "標題";
			this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
			// 
			// labelDuration
			// 
			this.labelDuration.AutoSize = true;
			this.labelDuration.Location = new System.Drawing.Point(556, 189);
			this.labelDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDuration.Name = "labelDuration";
			this.labelDuration.Size = new System.Drawing.Size(55, 13);
			this.labelDuration.TabIndex = 1;
			this.labelDuration.Text = "時間長度";
			// 
			// labelStartedTime
			// 
			this.labelStartedTime.AutoSize = true;
			this.labelStartedTime.Location = new System.Drawing.Point(30, 202);
			this.labelStartedTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelStartedTime.Name = "labelStartedTime";
			this.labelStartedTime.Size = new System.Drawing.Size(86, 13);
			this.labelStartedTime.TabIndex = 1;
			this.labelStartedTime.Text = "labelStartedTime";
			this.labelStartedTime.Click += new System.EventHandler(this.labelStartedTime_Click);
			// 
			// labelChannelName
			// 
			this.labelChannelName.AutoSize = true;
			this.labelChannelName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelChannelName.Location = new System.Drawing.Point(29, 153);
			this.labelChannelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelChannelName.Name = "labelChannelName";
			this.labelChannelName.Size = new System.Drawing.Size(61, 19);
			this.labelChannelName.TabIndex = 1;
			this.labelChannelName.Text = "頻道名稱";
			this.labelChannelName.Click += new System.EventHandler(this.labelChannelName_Click);
			// 
			// labelVidoType
			// 
			this.labelVidoType.AutoSize = true;
			this.labelVidoType.Location = new System.Drawing.Point(310, 48);
			this.labelVidoType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelVidoType.Name = "labelVidoType";
			this.labelVidoType.Size = new System.Drawing.Size(55, 13);
			this.labelVidoType.TabIndex = 1;
			this.labelVidoType.Text = "影片類型";
			this.labelVidoType.Click += new System.EventHandler(this.labelVidoType_Click);
			// 
			// labelPublishedTime
			// 
			this.labelPublishedTime.AutoSize = true;
			this.labelPublishedTime.Location = new System.Drawing.Point(30, 181);
			this.labelPublishedTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPublishedTime.Name = "labelPublishedTime";
			this.labelPublishedTime.Size = new System.Drawing.Size(98, 13);
			this.labelPublishedTime.TabIndex = 1;
			this.labelPublishedTime.Text = "labelPublishedTime";
			this.labelPublishedTime.Click += new System.EventHandler(this.labelPublishedTime_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(300, 34);
			this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(320, 179);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// ShowVideoDetailControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.labelVidoType);
			this.Controls.Add(this.labelDuration);
			this.Controls.Add(this.labelPublishedTime);
			this.Controls.Add(this.labelStartedTime);
			this.Controls.Add(this.labelChannelName);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.pictureBox);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximumSize = new System.Drawing.Size(650, 250);
			this.MinimumSize = new System.Drawing.Size(650, 250);
			this.Name = "ShowVideoDetailControl";
			this.Size = new System.Drawing.Size(650, 250);
			this.Load += new System.EventHandler(this.ShowVideoDetailControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelDuration;
		private System.Windows.Forms.Label labelStartedTime;
		private System.Windows.Forms.Label labelChannelName;
		private System.Windows.Forms.Label labelVidoType;
		private System.Windows.Forms.Label labelPublishedTime;
	}
}
