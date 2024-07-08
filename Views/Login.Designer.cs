namespace MailApp.Views
{
	partial class Login
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
			lbRegister = new Label();
			btSubmit = new Button();
			txbPassword = new TextBox();
			txbEmail = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			SuspendLayout();
			// 
			// lbRegister
			// 
			lbRegister.AutoSize = true;
			lbRegister.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
			lbRegister.ForeColor = Color.Blue;
			lbRegister.Location = new Point(328, 198);
			lbRegister.Name = "lbRegister";
			lbRegister.Size = new Size(67, 21);
			lbRegister.TabIndex = 17;
			lbRegister.Text = "Register";
			lbRegister.Click += lbRegister_Click;
			// 
			// btSubmit
			// 
			btSubmit.Font = new Font("Segoe UI", 14F);
			btSubmit.Location = new Point(408, 182);
			btSubmit.Name = "btSubmit";
			btSubmit.Size = new Size(112, 37);
			btSubmit.TabIndex = 16;
			btSubmit.Text = "Submit";
			btSubmit.UseVisualStyleBackColor = true;
			btSubmit.Click += btSubmit_Click;
			// 
			// txbPassword
			// 
			txbPassword.Font = new Font("Segoe UI", 12F);
			txbPassword.Location = new Point(207, 126);
			txbPassword.Name = "txbPassword";
			txbPassword.PasswordChar = '*';
			txbPassword.Size = new Size(313, 29);
			txbPassword.TabIndex = 14;
			// 
			// txbEmail
			// 
			txbEmail.Font = new Font("Segoe UI", 12F);
			txbEmail.Location = new Point(207, 83);
			txbEmail.Name = "txbEmail";
			txbEmail.Size = new Size(313, 29);
			txbEmail.TabIndex = 13;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14F);
			label3.Location = new Point(65, 130);
			label3.Name = "label3";
			label3.Size = new Size(100, 25);
			label3.TabIndex = 11;
			label3.Text = "Password: ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14F);
			label2.Location = new Point(65, 83);
			label2.Name = "label2";
			label2.Size = new Size(67, 25);
			label2.TabIndex = 10;
			label2.Text = "Email: ";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 20F);
			label1.Location = new Point(265, 27);
			label1.Name = "label1";
			label1.Size = new Size(84, 37);
			label1.TabIndex = 9;
			label1.Text = "Login";
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(584, 256);
			Controls.Add(lbRegister);
			Controls.Add(btSubmit);
			Controls.Add(txbPassword);
			Controls.Add(txbEmail);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Login";
			Text = "Login";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbRegister;
		private Button btSubmit;
		private TextBox txbPassword;
		private TextBox txbEmail;
		private Label label3;
		private Label label2;
		private Label label1;
	}
}