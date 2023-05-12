namespace VNote_Winapp_Jaien.Controls
{
	partial class ShowVNoteControl
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
			this.checkBoxFavorite = new System.Windows.Forms.CheckBox();
			this.checkBoxNoteLatter = new System.Windows.Forms.CheckBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.labelTag = new System.Windows.Forms.Label();
			this.txtTag = new System.Windows.Forms.TextBox();
			this.Note = new System.Windows.Forms.Label();
			this.txtNote = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.labelLastEditedat = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkBoxFavorite
			// 
			this.checkBoxFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxFavorite.AutoSize = true;
			this.checkBoxFavorite.Location = new System.Drawing.Point(48, 57);
			this.checkBoxFavorite.Margin = new System.Windows.Forms.Padding(4);
			this.checkBoxFavorite.Name = "checkBoxFavorite";
			this.checkBoxFavorite.Size = new System.Drawing.Size(75, 20);
			this.checkBoxFavorite.TabIndex = 0;
			this.checkBoxFavorite.Text = "Favorite";
			this.checkBoxFavorite.UseVisualStyleBackColor = true;
			this.checkBoxFavorite.CheckedChanged += new System.EventHandler(this.checkBoxFavorite_CheckedChanged);
			// 
			// checkBoxNoteLatter
			// 
			this.checkBoxNoteLatter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxNoteLatter.AutoSize = true;
			this.checkBoxNoteLatter.Location = new System.Drawing.Point(144, 57);
			this.checkBoxNoteLatter.Margin = new System.Windows.Forms.Padding(4);
			this.checkBoxNoteLatter.Name = "checkBoxNoteLatter";
			this.checkBoxNoteLatter.Size = new System.Drawing.Size(88, 20);
			this.checkBoxNoteLatter.TabIndex = 0;
			this.checkBoxNoteLatter.Text = "Note Later";
			this.checkBoxNoteLatter.UseVisualStyleBackColor = true;
			this.checkBoxNoteLatter.CheckedChanged += new System.EventHandler(this.checkBoxNoteLatter_CheckedChanged);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(61, 6);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(103, 58);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Save !";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// labelTag
			// 
			this.labelTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.labelTag.AutoSize = true;
			this.labelTag.Location = new System.Drawing.Point(30, 10);
			this.labelTag.Name = "labelTag";
			this.labelTag.Size = new System.Drawing.Size(35, 16);
			this.labelTag.TabIndex = 3;
			this.labelTag.Text = "TAG";
			this.labelTag.Click += new System.EventHandler(this.labelTag_Click);
			// 
			// txtTag
			// 
			this.txtTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtTag.Location = new System.Drawing.Point(47, 28);
			this.txtTag.Name = "txtTag";
			this.txtTag.Size = new System.Drawing.Size(316, 22);
			this.txtTag.TabIndex = 4;
			this.txtTag.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Note
			// 
			this.Note.AutoSize = true;
			this.Note.Location = new System.Drawing.Point(29, 29);
			this.Note.Name = "Note";
			this.Note.Size = new System.Drawing.Size(36, 16);
			this.Note.TabIndex = 3;
			this.Note.Text = "Note";
			// 
			// txtNote
			// 
			this.txtNote.Location = new System.Drawing.Point(33, 48);
			this.txtNote.Multiline = true;
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(690, 367);
			this.txtNote.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(0, 430);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(723, 87);
			this.panel1.TabIndex = 5;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.linkLabel1);
			this.panel3.Controls.Add(this.btnSave);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(508, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(215, 87);
			this.panel3.TabIndex = 1;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkColor = System.Drawing.Color.IndianRed;
			this.linkLabel1.Location = new System.Drawing.Point(62, 65);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(102, 16);
			this.linkLabel1.TabIndex = 2;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Delete this Note";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.labelTag);
			this.panel2.Controls.Add(this.checkBoxFavorite);
			this.panel2.Controls.Add(this.txtTag);
			this.panel2.Controls.Add(this.checkBoxNoteLatter);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(413, 87);
			this.panel2.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(452, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Last Edited at : ";
			// 
			// labelLastEditedat
			// 
			this.labelLastEditedat.AutoSize = true;
			this.labelLastEditedat.Location = new System.Drawing.Point(553, 28);
			this.labelLastEditedat.Name = "labelLastEditedat";
			this.labelLastEditedat.Size = new System.Drawing.Size(75, 16);
			this.labelLastEditedat.TabIndex = 6;
			this.labelLastEditedat.Text = "lastedittime";
			// 
			// ShowVNoteControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelLastEditedat);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtNote);
			this.Controls.Add(this.Note);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(723, 523);
			this.Name = "ShowVNoteControl";
			this.Size = new System.Drawing.Size(751, 532);
			this.Load += new System.EventHandler(this.ShowVNoteControl_Load);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxFavorite;
		private System.Windows.Forms.CheckBox checkBoxNoteLatter;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label labelTag;
		private System.Windows.Forms.TextBox txtTag;
		private System.Windows.Forms.Label Note;
		private System.Windows.Forms.TextBox txtNote;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label labelLastEditedat;
	}
}
