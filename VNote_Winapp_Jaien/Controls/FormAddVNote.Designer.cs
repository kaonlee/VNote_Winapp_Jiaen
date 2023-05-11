namespace VNote_Winapp_Jaien.Controls
{
	partial class FormAddVNote
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
			this.btnChek = new System.Windows.Forms.Button();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.showVideoDetailControl1 = new VNote_Winapp_Jaien.ShowVideoDetailControl();
			this.SuspendLayout();
			// 
			// btnChek
			// 
			this.btnChek.Location = new System.Drawing.Point(460, 124);
			this.btnChek.Margin = new System.Windows.Forms.Padding(4);
			this.btnChek.Name = "btnChek";
			this.btnChek.Size = new System.Drawing.Size(100, 34);
			this.btnChek.TabIndex = 1;
			this.btnChek.Text = "Check!";
			this.btnChek.UseVisualStyleBackColor = true;
			this.btnChek.Click += new System.EventHandler(this.btnChek_Click);
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(29, 129);
			this.txtUrl.Margin = new System.Windows.Forms.Padding(4);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(407, 25);
			this.txtUrl.TabIndex = 2;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Thistle;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(747, 124);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(124, 88);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add it !";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// showVideoDetailControl1
			// 
			this.showVideoDetailControl1.AutoSize = true;
			this.showVideoDetailControl1.Location = new System.Drawing.Point(11, 158);
			this.showVideoDetailControl1.Margin = new System.Windows.Forms.Padding(2);
			this.showVideoDetailControl1.MaximumSize = new System.Drawing.Size(867, 365);
			this.showVideoDetailControl1.MinimumSize = new System.Drawing.Size(867, 365);
			this.showVideoDetailControl1.Name = "showVideoDetailControl1";
			this.showVideoDetailControl1.Size = new System.Drawing.Size(867, 365);
			this.showVideoDetailControl1.TabIndex = 3;
			this.showVideoDetailControl1.Visible = false;
			// 
			// FormAddVNote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(884, 661);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.showVideoDetailControl1);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.btnChek);
			this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormAddVNote";
			this.Text = "FormAddVNote";
			this.Load += new System.EventHandler(this.FormAddVNote_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnChek;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Button btnAdd;
		private ShowVideoDetailControl showVideoDetailControl1;
	}
}