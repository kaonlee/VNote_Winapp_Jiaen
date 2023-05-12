namespace VNote_Winapp_Jaien
{
	partial class FormSignUp
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPwCheck = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(89, 207);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 40);
			this.button1.TabIndex = 3;
			this.button1.Text = "Create Account !";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "UserName";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(53, 55);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(200, 22);
			this.txtUserName.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(53, 120);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '×';
			this.txtPassword.Size = new System.Drawing.Size(200, 22);
			this.txtPassword.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(186, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 12);
			this.label3.TabIndex = 1;
			this.label3.Text = "check again !";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// txtPwCheck
			// 
			this.txtPwCheck.Location = new System.Drawing.Point(53, 144);
			this.txtPwCheck.Name = "txtPwCheck";
			this.txtPwCheck.PasswordChar = '×';
			this.txtPwCheck.Size = new System.Drawing.Size(200, 22);
			this.txtPwCheck.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::VNote_Winapp_Jaien.Properties.Resources.shopping_sign_tablet_hand;
			this.pictureBox1.Location = new System.Drawing.Point(200, 217);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(97, 88);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// FormSignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 330);
			this.Controls.Add(this.txtPwCheck);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "FormSignUp";
			this.Text = "FormSignUp";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPwCheck;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}