namespace VNote_Winapp_Jaien.Controls
{
	partial class ShowVideoDetailatVNote
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
			this.labelPublishedTime = new System.Windows.Forms.Label();
			this.labelStartedTime = new System.Windows.Forms.Label();
			this.labelChannelName = new System.Windows.Forms.Label();
			this.labelTitle = new System.Windows.Forms.Label();
			this.btnWatch = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// labelPublishedTime
			// 
			this.labelPublishedTime.AutoSize = true;
			this.labelPublishedTime.Location = new System.Drawing.Point(14, 269);
			this.labelPublishedTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPublishedTime.Name = "labelPublishedTime";
			this.labelPublishedTime.Size = new System.Drawing.Size(98, 13);
			this.labelPublishedTime.TabIndex = 5;
			this.labelPublishedTime.Text = "labelPublishedTime";
			// 
			// labelStartedTime
			// 
			this.labelStartedTime.AutoSize = true;
			this.labelStartedTime.Location = new System.Drawing.Point(14, 290);
			this.labelStartedTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelStartedTime.Name = "labelStartedTime";
			this.labelStartedTime.Size = new System.Drawing.Size(86, 13);
			this.labelStartedTime.TabIndex = 6;
			this.labelStartedTime.Text = "labelStartedTime";
			// 
			// labelChannelName
			// 
			this.labelChannelName.AutoSize = true;
			this.labelChannelName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelChannelName.Location = new System.Drawing.Point(13, 241);
			this.labelChannelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelChannelName.Name = "labelChannelName";
			this.labelChannelName.Size = new System.Drawing.Size(61, 19);
			this.labelChannelName.TabIndex = 7;
			this.labelChannelName.Text = "頻道名稱";
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(10, 180);
			this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTitle.MaximumSize = new System.Drawing.Size(200, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(42, 22);
			this.labelTitle.TabIndex = 8;
			this.labelTitle.Text = "標題";
			// 
			// btnWatch
			// 
			this.btnWatch.Location = new System.Drawing.Point(14, 346);
			this.btnWatch.Name = "btnWatch";
			this.btnWatch.Size = new System.Drawing.Size(192, 37);
			this.btnWatch.TabIndex = 9;
			this.btnWatch.Text = "Watch Now !";
			this.btnWatch.UseVisualStyleBackColor = true;
			this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox.Location = new System.Drawing.Point(14, 45);
			this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(196, 115);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 2;
			this.pictureBox.TabStop = false;
			// 
			// ShowVideoDetailatVNote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnWatch);
			this.Controls.Add(this.labelPublishedTime);
			this.Controls.Add(this.labelStartedTime);
			this.Controls.Add(this.labelChannelName);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.pictureBox);
			this.Name = "ShowVideoDetailatVNote";
			this.Size = new System.Drawing.Size(212, 585);
			this.Load += new System.EventHandler(this.ShowVideoDetailatVNote_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelPublishedTime;
		private System.Windows.Forms.Label labelStartedTime;
		private System.Windows.Forms.Label labelChannelName;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button btnWatch;
	}
}
