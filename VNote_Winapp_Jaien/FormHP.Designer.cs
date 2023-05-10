namespace VNote_Winapp_Jaien
{
	partial class FormHP
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
			this.panelMenu = new System.Windows.Forms.Panel();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnNewVNote = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelTop = new System.Windows.Forms.Panel();
			this.btnLogOut = new System.Windows.Forms.Button();
			this.panelMain = new System.Windows.Forms.Panel();
			this.panelMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.Controls.Add(this.button7);
			this.panelMenu.Controls.Add(this.button6);
			this.panelMenu.Controls.Add(this.button4);
			this.panelMenu.Controls.Add(this.button3);
			this.panelMenu.Controls.Add(this.button2);
			this.panelMenu.Controls.Add(this.btnNewVNote);
			this.panelMenu.Controls.Add(this.pictureBox1);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(120, 681);
			this.panelMenu.TabIndex = 0;
			// 
			// button7
			// 
			this.button7.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button7.Location = new System.Drawing.Point(0, 557);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(120, 62);
			this.button7.TabIndex = 7;
			this.button7.Text = "Edit Account";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button6.Location = new System.Drawing.Point(0, 619);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(120, 62);
			this.button6.TabIndex = 6;
			this.button6.Text = "About";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Top;
			this.button4.Location = new System.Drawing.Point(0, 321);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(120, 67);
			this.button4.TabIndex = 4;
			this.button4.Text = "Favorite <3";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Dock = System.Windows.Forms.DockStyle.Top;
			this.button3.Location = new System.Drawing.Point(0, 254);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 67);
			this.button3.TabIndex = 3;
			this.button3.Text = "Note Latter";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.Location = new System.Drawing.Point(0, 187);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 67);
			this.button2.TabIndex = 2;
			this.button2.Text = "My VNote";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btnNewVNote
			// 
			this.btnNewVNote.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNewVNote.Location = new System.Drawing.Point(0, 120);
			this.btnNewVNote.Name = "btnNewVNote";
			this.btnNewVNote.Size = new System.Drawing.Size(120, 67);
			this.btnNewVNote.TabIndex = 1;
			this.btnNewVNote.Text = "New VNote";
			this.btnNewVNote.UseVisualStyleBackColor = true;
			this.btnNewVNote.Click += new System.EventHandler(this.btnNewVNote_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 120);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panelTop
			// 
			this.panelTop.Controls.Add(this.btnLogOut);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(120, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(944, 53);
			this.panelTop.TabIndex = 1;
			// 
			// btnLogOut
			// 
			this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnLogOut.Location = new System.Drawing.Point(835, 0);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(109, 53);
			this.btnLogOut.TabIndex = 6;
			this.btnLogOut.Text = "Logout";
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// panelMain
			// 
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(120, 53);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(944, 628);
			this.panelMain.TabIndex = 2;
			// 
			// FormHP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 681);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.panelTop);
			this.Controls.Add(this.panelMenu);
			this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "FormHP";
			this.Text = "VNote";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHP_FormClosing);
			this.panelMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelTop.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnNewVNote;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button btnLogOut;
		private System.Windows.Forms.Button button4;
	}
}