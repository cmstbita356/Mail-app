namespace MailApp.Views
{
	partial class CheckSendedUC
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
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			txbTime = new TextBox();
			txbSubject = new TextBox();
			txbContext = new TextBox();
			txbReceiver = new TextBox();
			dgv = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.Location = new Point(371, 130);
			label3.Name = "label3";
			label3.Size = new Size(69, 21);
			label3.TabIndex = 28;
			label3.Text = "Reciever";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(170, 130);
			label2.Name = "label2";
			label2.Size = new Size(66, 21);
			label2.TabIndex = 27;
			label2.Text = "Context:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(3, 130);
			label1.Name = "label1";
			label1.Size = new Size(47, 21);
			label1.TabIndex = 26;
			label1.Text = "Time:";
			// 
			// txbTime
			// 
			txbTime.Font = new Font("Segoe UI", 10F);
			txbTime.Location = new Point(3, 154);
			txbTime.Name = "txbTime";
			txbTime.ReadOnly = true;
			txbTime.Size = new Size(161, 25);
			txbTime.TabIndex = 24;
			// 
			// txbSubject
			// 
			txbSubject.Font = new Font("Segoe UI", 10F);
			txbSubject.Location = new Point(3, 185);
			txbSubject.Multiline = true;
			txbSubject.Name = "txbSubject";
			txbSubject.ReadOnly = true;
			txbSubject.Size = new Size(543, 97);
			txbSubject.TabIndex = 23;
			// 
			// txbContext
			// 
			txbContext.Font = new Font("Segoe UI", 10F);
			txbContext.Location = new Point(170, 154);
			txbContext.Name = "txbContext";
			txbContext.ReadOnly = true;
			txbContext.Size = new Size(195, 25);
			txbContext.TabIndex = 22;
			// 
			// txbReceiver
			// 
			txbReceiver.Font = new Font("Segoe UI", 10F);
			txbReceiver.Location = new Point(371, 154);
			txbReceiver.Name = "txbReceiver";
			txbReceiver.ReadOnly = true;
			txbReceiver.Size = new Size(175, 25);
			txbReceiver.TabIndex = 21;
			// 
			// dgv
			// 
			dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv.Location = new Point(3, 3);
			dgv.MultiSelect = false;
			dgv.Name = "dgv";
			dgv.Size = new Size(543, 124);
			dgv.TabIndex = 20;
			// 
			// CheckSendedUC
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txbTime);
			Controls.Add(txbSubject);
			Controls.Add(txbContext);
			Controls.Add(txbReceiver);
			Controls.Add(dgv);
			Name = "CheckSendedUC";
			Size = new Size(550, 285);
			((System.ComponentModel.ISupportInitialize)dgv).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox txbTime;
		private TextBox txbSubject;
		private TextBox txbContext;
		private TextBox txbReceiver;
		private DataGridView dgv;
	}
}
