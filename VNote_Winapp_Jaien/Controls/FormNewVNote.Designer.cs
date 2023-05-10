namespace VNote_Winapp_Jaien.Controls
{
	partial class FormNewVNote
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCheck = new System.Windows.Forms.Button();
			this.showVideoDetailControl1 = new VNote_Winapp_Jaien.ShowVideoDetailControl();
			this.btnAddVideo = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(16, 22);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(383, 20);
			this.txtUrl.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCheck);
			this.groupBox1.Controls.Add(this.txtUrl);
			this.groupBox1.Location = new System.Drawing.Point(41, 30);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(497, 55);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "YouTubeVideoUrl";
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(405, 20);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(75, 23);
			this.btnCheck.TabIndex = 3;
			this.btnCheck.Text = "Check!";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.button1_Click);
			// 
			// showVideoDetailControl1
			// 
			this.showVideoDetailControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.showVideoDetailControl1.Location = new System.Drawing.Point(22, 109);
			this.showVideoDetailControl1.Margin = new System.Windows.Forms.Padding(2);
			this.showVideoDetailControl1.Name = "showVideoDetailControl1";
			this.showVideoDetailControl1.Size = new System.Drawing.Size(650, 250);
			this.showVideoDetailControl1.TabIndex = 0;
			// 
			// btnAddVideo
			// 
			this.btnAddVideo.Location = new System.Drawing.Point(629, 83);
			this.btnAddVideo.Name = "btnAddVideo";
			this.btnAddVideo.Size = new System.Drawing.Size(64, 60);
			this.btnAddVideo.TabIndex = 4;
			this.btnAddVideo.Text = "Add it !";
			this.btnAddVideo.UseVisualStyleBackColor = true;
			this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
			// 
			// FormNewVNote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(904, 518);
			this.Controls.Add(this.btnAddVideo);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.showVideoDetailControl1);
			this.Name = "FormNewVNote";
			this.Text = "FormNewVNote";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ShowVideoDetailControl showVideoDetailControl1;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.Button btnAddVideo;
	}
}