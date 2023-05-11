namespace VNote_Winapp_Jaien.Controls
{
	partial class FormReadEditVNote
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.showVNoteControl1 = new VNote_Winapp_Jaien.Controls.ShowVNoteControl();
			this.showVideoDetailatVNote1 = new VNote_Winapp_Jaien.Controls.ShowVideoDetailatVNote();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.showVideoDetailatVNote1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(224, 620);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.showVNoteControl1);
			this.panel2.Location = new System.Drawing.Point(230, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(758, 552);
			this.panel2.TabIndex = 2;
			// 
			// showVNoteControl1
			// 
			this.showVNoteControl1.AutoSize = true;
			this.showVNoteControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showVNoteControl1.Location = new System.Drawing.Point(19, 16);
			this.showVNoteControl1.Margin = new System.Windows.Forms.Padding(4);
			this.showVNoteControl1.MaximumSize = new System.Drawing.Size(723, 523);
			this.showVNoteControl1.MinimumSize = new System.Drawing.Size(723, 523);
			this.showVNoteControl1.Name = "showVNoteControl1";
			this.showVNoteControl1.Size = new System.Drawing.Size(723, 523);
			this.showVNoteControl1.TabIndex = 0;
			this.showVNoteControl1.Load += new System.EventHandler(this.showVNoteControl1_Load);
			// 
			// showVideoDetailatVNote1
			// 
			this.showVideoDetailatVNote1.Location = new System.Drawing.Point(0, 0);
			this.showVideoDetailatVNote1.Name = "showVideoDetailatVNote1";
			this.showVideoDetailatVNote1.Size = new System.Drawing.Size(224, 620);
			this.showVideoDetailatVNote1.TabIndex = 0;
			this.showVideoDetailatVNote1.Load += new System.EventHandler(this.showVideoDetailatVNote1_Load);
			// 
			// FormReadEditVNote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1035, 620);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FormReadEditVNote";
			this.Text = "ReadEditVNote";
			this.Load += new System.EventHandler(this.FormReadEditVNote_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private ShowVideoDetailatVNote showVideoDetailatVNote1;
		private ShowVNoteControl showVNoteControl1;
	}
}