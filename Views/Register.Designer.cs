namespace MailApp.Views
{
	partial class Register
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			txbEmail = new TextBox();
			txbPassword = new TextBox();
			txbRePassword = new TextBox();
			btSubmit = new Button();
			lbLogin = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 20F);
			label1.Location = new Point(222, 21);
			label1.Name = "label1";
			label1.Size = new Size(112, 37);
			label1.TabIndex = 0;
			label1.Text = "Reigster";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14F);
			label2.Location = new Point(22, 77);
			label2.Name = "label2";
			label2.Size = new Size(67, 25);
			label2.TabIndex = 1;
			label2.Text = "Email: ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14F);
			label3.Location = new Point(22, 124);
			label3.Name = "label3";
			label3.Size = new Size(100, 25);
			label3.TabIndex = 2;
			label3.Text = "Password: ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 14F);
			label4.Location = new Point(22, 176);
			label4.Name = "label4";
			label4.Size = new Size(123, 25);
			label4.TabIndex = 3;
			label4.Text = "Re-Password:";
			// 
			// txbEmail
			// 
			txbEmail.Font = new Font("Segoe UI", 12F);
			txbEmail.Location = new Point(164, 77);
			txbEmail.Name = "txbEmail";
			txbEmail.Size = new Size(313, 29);
			txbEmail.TabIndex = 4;
			// 
			// txbPassword
			// 
			txbPassword.Font = new Font("Segoe UI", 12F);
			txbPassword.Location = new Point(164, 120);
			txbPassword.Name = "txbPassword";
			txbPassword.PasswordChar = '*';
			txbPassword.Size = new Size(313, 29);
			txbPassword.TabIndex = 5;
			// 
			// txbRePassword
			// 
			txbRePassword.Font = new Font("Segoe UI", 12F);
			txbRePassword.Location = new Point(164, 172);
			txbRePassword.Name = "txbRePassword";
			txbRePassword.PasswordChar = '*';
			txbRePassword.Size = new Size(313, 29);
			txbRePassword.TabIndex = 6;
			// 
			// btSubmit
			// 
			btSubmit.Font = new Font("Segoe UI", 14F);
			btSubmit.Location = new Point(365, 240);
			btSubmit.Name = "btSubmit";
			btSubmit.Size = new Size(112, 37);
			btSubmit.TabIndex = 7;
			btSubmit.Text = "Submit";
			btSubmit.UseVisualStyleBackColor = true;
			btSubmit.Click += btSubmit_Click;
			// 
			// lbLogin
			// 
			lbLogin.AutoSize = true;
			lbLogin.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
			lbLogin.ForeColor = Color.Blue;
			lbLogin.Location = new Point(285, 256);
			lbLogin.Name = "lbLogin";
			lbLogin.Size = new Size(49, 21);
			lbLogin.TabIndex = 8;
			lbLogin.Text = "Login";
			lbLogin.Click += lbLogin_Click;
			// 
			// Register
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(584, 311);
			Controls.Add(lbLogin);
			Controls.Add(btSubmit);
			Controls.Add(txbRePassword);
			Controls.Add(txbPassword);
			Controls.Add(txbEmail);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Register";
			Text = "Register";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox txbEmail;
		private TextBox txbPassword;
		private TextBox txbRePassword;
		private Button btSubmit;
		private Label lbLogin;
	}
}