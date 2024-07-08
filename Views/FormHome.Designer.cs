namespace MailApp
{
	partial class FormHome
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			timer1 = new System.Windows.Forms.Timer(components);
			pictureBox1 = new PictureBox();
			button1 = new Button();
			button2 = new Button();
			lbEmail = new Label();
			panel1 = new Panel();
			btCheck = new Button();
			txbSend = new Button();
			button3 = new Button();
			btLogout = new Button();
			btSended = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// timer1
			// 
			timer1.Tick += timer1_Tick;
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox1.Location = new Point(26, 17);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(85, 85);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// button1
			// 
			button1.BackColor = Color.Black;
			button1.Enabled = false;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Location = new Point(2, 108);
			button1.Name = "button1";
			button1.Size = new Size(760, 7);
			button1.TabIndex = 1;
			button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			button2.BackColor = Color.Black;
			button2.Enabled = false;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Location = new Point(181, 108);
			button2.Name = "button2";
			button2.Size = new Size(7, 308);
			button2.TabIndex = 2;
			button2.UseVisualStyleBackColor = false;
			// 
			// lbEmail
			// 
			lbEmail.AutoSize = true;
			lbEmail.Font = new Font("Segoe UI", 14F);
			lbEmail.Location = new Point(130, 44);
			lbEmail.Name = "lbEmail";
			lbEmail.Size = new Size(58, 25);
			lbEmail.TabIndex = 3;
			lbEmail.Text = "Email";
			// 
			// panel1
			// 
			panel1.Location = new Point(193, 120);
			panel1.Name = "panel1";
			panel1.Size = new Size(550, 285);
			panel1.TabIndex = 4;
			// 
			// btCheck
			// 
			btCheck.Font = new Font("Segoe UI", 12F);
			btCheck.Location = new Point(26, 131);
			btCheck.Name = "btCheck";
			btCheck.Size = new Size(127, 37);
			btCheck.TabIndex = 5;
			btCheck.Text = "Check Mails";
			btCheck.UseVisualStyleBackColor = true;
			btCheck.Click += btCheck_Click;
			// 
			// txbSend
			// 
			txbSend.Font = new Font("Segoe UI", 12F);
			txbSend.Location = new Point(26, 174);
			txbSend.Name = "txbSend";
			txbSend.Size = new Size(127, 37);
			txbSend.TabIndex = 6;
			txbSend.Text = "Send Mails";
			txbSend.UseVisualStyleBackColor = true;
			txbSend.Click += txbSend_Click;
			// 
			// button3
			// 
			button3.Font = new Font("Segoe UI", 12F);
			button3.Location = new Point(26, 260);
			button3.Name = "button3";
			button3.Size = new Size(127, 37);
			button3.TabIndex = 7;
			button3.Text = "Check Deleted";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// btLogout
			// 
			btLogout.BackColor = Color.Red;
			btLogout.FlatStyle = FlatStyle.Flat;
			btLogout.Font = new Font("Segoe UI", 12F);
			btLogout.ForeColor = Color.Transparent;
			btLogout.Location = new Point(26, 363);
			btLogout.Name = "btLogout";
			btLogout.Size = new Size(127, 37);
			btLogout.TabIndex = 8;
			btLogout.Text = "Log Out";
			btLogout.UseVisualStyleBackColor = false;
			btLogout.Click += btLogout_Click;
			// 
			// btSended
			// 
			btSended.Font = new Font("Segoe UI", 12F);
			btSended.Location = new Point(26, 217);
			btSended.Name = "btSended";
			btSended.Size = new Size(127, 37);
			btSended.TabIndex = 9;
			btSended.Text = "Check Sended";
			btSended.UseVisualStyleBackColor = true;
			btSended.Click += btSended_Click;
			// 
			// FormHome
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(754, 409);
			Controls.Add(btSended);
			Controls.Add(btLogout);
			Controls.Add(button3);
			Controls.Add(txbSend);
			Controls.Add(btCheck);
			Controls.Add(panel1);
			Controls.Add(lbEmail);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(pictureBox1);
			Name = "FormHome";
			Text = "Home";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Timer timer1;
		private PictureBox pictureBox1;
		private Button button1;
		private Button button2;
		private Label lbEmail;
		private Panel panel1;
		private Button btCheck;
		private Button txbSend;
		private Button button3;
		private Button btLogout;
		private Button btSended;
	}
}
