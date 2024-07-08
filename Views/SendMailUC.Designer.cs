namespace MailApp.Views
{
	partial class SendMailUC
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			txbReceiver = new TextBox();
			txbContext = new TextBox();
			txbSubject = new TextBox();
			btSend = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10F);
			label1.Location = new Point(17, 17);
			label1.Name = "label1";
			label1.Size = new Size(59, 19);
			label1.TabIndex = 0;
			label1.Text = "Send to:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10F);
			label2.Location = new Point(17, 53);
			label2.Name = "label2";
			label2.Size = new Size(64, 19);
			label2.TabIndex = 1;
			label2.Text = "Context: ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10F);
			label3.Location = new Point(17, 89);
			label3.Name = "label3";
			label3.Size = new Size(56, 19);
			label3.TabIndex = 2;
			label3.Text = "Subject:";
			// 
			// txbReceiver
			// 
			txbReceiver.Location = new Point(94, 15);
			txbReceiver.Name = "txbReceiver";
			txbReceiver.Size = new Size(432, 23);
			txbReceiver.TabIndex = 3;
			// 
			// txbContext
			// 
			txbContext.Location = new Point(94, 53);
			txbContext.Name = "txbContext";
			txbContext.Size = new Size(432, 23);
			txbContext.TabIndex = 4;
			// 
			// txbSubject
			// 
			txbSubject.Location = new Point(17, 121);
			txbSubject.Multiline = true;
			txbSubject.Name = "txbSubject";
			txbSubject.Size = new Size(509, 144);
			txbSubject.TabIndex = 5;
			// 
			// btSend
			// 
			btSend.Font = new Font("Segoe UI", 10F);
			btSend.Location = new Point(404, 89);
			btSend.Name = "btSend";
			btSend.Size = new Size(122, 26);
			btSend.TabIndex = 6;
			btSend.Text = "Send";
			btSend.UseVisualStyleBackColor = true;
			btSend.Click += btSend_Click;
			// 
			// SendMailUC
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(btSend);
			Controls.Add(txbSubject);
			Controls.Add(txbContext);
			Controls.Add(txbReceiver);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "SendMailUC";
			Size = new Size(550, 285);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txbReceiver;
		private TextBox txbContext;
		private TextBox txbSubject;
		private Button btSend;
	}
}
