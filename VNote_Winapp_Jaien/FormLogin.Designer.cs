namespace VNote_Winapp_Jaien
{
	partial class FormLogin
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnSignUp = new System.Windows.Forms.Button();
			this.Login = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.Login.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::VNote_Winapp_Jaien.Properties.Resources.messageImage_1683828638056;
			this.pictureBox1.Location = new System.Drawing.Point(51, 149);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(345, 255);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(52, 54);
			this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(225, 28);
			this.txtUserName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "User Name";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(52, 121);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '×';
			this.txtPassword.Size = new System.Drawing.Size(225, 28);
			this.txtPassword.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 98);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(80, 168);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(78, 42);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnSignUp
			// 
			this.btnSignUp.Location = new System.Drawing.Point(171, 168);
			this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
			this.btnSignUp.Name = "btnSignUp";
			this.btnSignUp.Size = new System.Drawing.Size(79, 42);
			this.btnSignUp.TabIndex = 3;
			this.btnSignUp.Text = "Sign Up";
			this.btnSignUp.UseVisualStyleBackColor = true;
			this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
			// 
			// Login
			// 
			this.Login.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Login.Controls.Add(this.txtUserName);
			this.Login.Controls.Add(this.btnSignUp);
			this.Login.Controls.Add(this.txtPassword);
			this.Login.Controls.Add(this.btnLogin);
			this.Login.Controls.Add(this.label1);
			this.Login.Controls.Add(this.label2);
			this.Login.Location = new System.Drawing.Point(401, 159);
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(346, 234);
			this.Login.TabIndex = 4;
			this.Login.TabStop = false;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.Login);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximumSize = new System.Drawing.Size(800, 600);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "FormLogin";
			this.Text = "FormLogin";
			this.Load += new System.EventHandler(this.FormLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.Login.ResumeLayout(false);
			this.Login.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnSignUp;
		private System.Windows.Forms.GroupBox Login;
	}
}