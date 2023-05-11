namespace VNote_Winapp_Jaien.Controls
{
	partial class FormReadVNotes
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
			this.searchVNotesList1 = new VNote_Winapp_Jaien.Controls.SearchVNotesList();
			this.SuspendLayout();
			// 
			// searchVNotesList1
			// 
			this.searchVNotesList1.AllowDrop = true;
			this.searchVNotesList1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.searchVNotesList1.Location = new System.Drawing.Point(12, 12);
			this.searchVNotesList1.Name = "searchVNotesList1";
			this.searchVNotesList1.Size = new System.Drawing.Size(849, 554);
			this.searchVNotesList1.TabIndex = 0;
			// 
			// FormReadVNotes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1035, 620);
			this.Controls.Add(this.searchVNotesList1);
			this.Name = "FormReadVNotes";
			this.Text = "ReadVNotes";
			this.Load += new System.EventHandler(this.FormReadVNotes_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private SearchVNotesList searchVNotesList1;
	}
}