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
			this.labelPublishedTime.Location = new System.Drawing.Point(12, 246);
			this.labelPublishedTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPublishedTime.Name = "labelPublishedTime";
			this.labelPublishedTime.Size = new System.Drawing.Size(74, 12);
			this.labelPublishedTime.TabIndex = 5;
			this.labelPublishedTime.Text = "PublishedTime";
			this.labelPublishedTime.Click += new System.EventHandler(this.labelPublishedTime_Click);
			// 
			// labelChannelName
			// 
			this.labelChannelName.AutoSize = true;
			this.labelChannelName.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelChannelName.Location = new System.Drawing.Point(10, 258);
			this.labelChannelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelChannelName.Name = "labelChannelName";
			this.labelChannelName.Size = new System.Drawing.Size(61, 19);
			this.labelChannelName.TabIndex = 7;
			this.labelChannelName.Text = "頻道名稱";
			this.labelChannelName.Click += new System.EventHandler(this.labelChannelName_Click);
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(10, 179);
			this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTitle.MaximumSize = new System.Drawing.Size(200, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(42, 22);
			this.labelTitle.TabIndex = 8;
			this.labelTitle.Text = "標題";
			// 
			// btnWatch
			// 
			this.btnWatch.Location = new System.Drawing.Point(14, 319);
			this.btnWatch.Name = "btnWatch";
			this.btnWatch.Size = new System.Drawing.Size(192, 34);
			this.btnWatch.TabIndex = 9;
			this.btnWatch.Text = "Watch Now !";
			this.btnWatch.UseVisualStyleBackColor = true;
			this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(14, 42);
			this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(196, 106);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 2;
			this.pictureBox.TabStop = false;
			// 
			// ShowVideoDetailatVNote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.btnWatch);
			this.Controls.Add(this.labelPublishedTime);
			this.Controls.Add(this.labelChannelName);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.pictureBox);
			this.Name = "ShowVideoDetailatVNote";
			this.Size = new System.Drawing.Size(212, 540);
			this.Load += new System.EventHandler(this.ShowVideoDetailatVNote_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelPublishedTime;
		private System.Windows.Forms.Label labelChannelName;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button btnWatch;
	}
}
