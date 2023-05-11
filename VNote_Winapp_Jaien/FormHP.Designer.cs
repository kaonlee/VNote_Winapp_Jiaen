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
			this.btnFavorite = new System.Windows.Forms.Button();
			this.btnNoteLatter = new System.Windows.Forms.Button();
			this.btnVNotesList = new System.Windows.Forms.Button();
			this.btnNewVNote = new System.Windows.Forms.Button();
			this.panelMain = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnLogOut = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.panelMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.Controls.Add(this.button7);
			this.panelMenu.Controls.Add(this.btnLogOut);
			this.panelMenu.Controls.Add(this.btnFavorite);
			this.panelMenu.Controls.Add(this.btnNoteLatter);
			this.panelMenu.Controls.Add(this.btnVNotesList);
			this.panelMenu.Controls.Add(this.btnNewVNote);
			this.panelMenu.Controls.Add(this.pictureBox1);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(120, 661);
			this.panelMenu.TabIndex = 0;
			// 
			// btnFavorite
			// 
			this.btnFavorite.BackColor = System.Drawing.Color.Snow;
			this.btnFavorite.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFavorite.ForeColor = System.Drawing.Color.Green;
			this.btnFavorite.Location = new System.Drawing.Point(0, 321);
			this.btnFavorite.Name = "btnFavorite";
			this.btnFavorite.Size = new System.Drawing.Size(120, 67);
			this.btnFavorite.TabIndex = 4;
			this.btnFavorite.Text = "Favorite <3";
			this.btnFavorite.UseVisualStyleBackColor = false;
			this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
			// 
			// btnNoteLatter
			// 
			this.btnNoteLatter.BackColor = System.Drawing.Color.Snow;
			this.btnNoteLatter.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNoteLatter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNoteLatter.ForeColor = System.Drawing.Color.Goldenrod;
			this.btnNoteLatter.Location = new System.Drawing.Point(0, 254);
			this.btnNoteLatter.Name = "btnNoteLatter";
			this.btnNoteLatter.Size = new System.Drawing.Size(120, 67);
			this.btnNoteLatter.TabIndex = 3;
			this.btnNoteLatter.Text = "Note Later";
			this.btnNoteLatter.UseVisualStyleBackColor = false;
			this.btnNoteLatter.Click += new System.EventHandler(this.btnNoteLatter_Click);
			// 
			// btnVNotesList
			// 
			this.btnVNotesList.BackColor = System.Drawing.Color.Snow;
			this.btnVNotesList.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnVNotesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVNotesList.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnVNotesList.Location = new System.Drawing.Point(0, 187);
			this.btnVNotesList.Name = "btnVNotesList";
			this.btnVNotesList.Size = new System.Drawing.Size(120, 67);
			this.btnVNotesList.TabIndex = 2;
			this.btnVNotesList.Text = "My VNotes";
			this.btnVNotesList.UseVisualStyleBackColor = false;
			this.btnVNotesList.Click += new System.EventHandler(this.btnVNotesList_Click);
			// 
			// btnNewVNote
			// 
			this.btnNewVNote.BackColor = System.Drawing.Color.Snow;
			this.btnNewVNote.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNewVNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewVNote.ForeColor = System.Drawing.Color.Crimson;
			this.btnNewVNote.Location = new System.Drawing.Point(0, 120);
			this.btnNewVNote.Name = "btnNewVNote";
			this.btnNewVNote.Size = new System.Drawing.Size(120, 67);
			this.btnNewVNote.TabIndex = 1;
			this.btnNewVNote.Text = "New VNote";
			this.btnNewVNote.UseVisualStyleBackColor = false;
			this.btnNewVNote.Click += new System.EventHandler(this.btnNewVNote_Click);
			// 
			// panelMain
			// 
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(120, 0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(884, 661);
			this.panelMain.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Image = global::VNote_Winapp_Jaien.Properties.Resources.messageImage_1683828638056;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 120);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnLogOut
			// 
			this.btnLogOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogOut.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.btnLogOut.Location = new System.Drawing.Point(0, 608);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(120, 53);
			this.btnLogOut.TabIndex = 8;
			this.btnLogOut.Text = "Logout";
			this.btnLogOut.UseVisualStyleBackColor = false;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Snow;
			this.button7.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.ForeColor = System.Drawing.Color.CadetBlue;
			this.button7.Location = new System.Drawing.Point(0, 546);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(120, 62);
			this.button7.TabIndex = 9;
			this.button7.Text = "Edit Account";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// FormHP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(1004, 661);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.panelMenu);
			this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "FormHP";
			this.Text = "VNote";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHP_FormClosing);
			this.Load += new System.EventHandler(this.FormHP_Load);
			this.panelMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Button btnNoteLatter;
		private System.Windows.Forms.Button btnVNotesList;
		private System.Windows.Forms.Button btnNewVNote;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Button btnFavorite;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button btnLogOut;
	}
}