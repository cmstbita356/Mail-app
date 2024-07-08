namespace MailApp.Views
{
	partial class CheckDeletedUC
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
			btReturn = new Button();
			txbTime = new TextBox();
			txbSubject = new TextBox();
			txbContext = new TextBox();
			txbSender = new TextBox();
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
			label3.Size = new Size(62, 21);
			label3.TabIndex = 19;
			label3.Text = "Sender:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(170, 130);
			label2.Name = "label2";
			label2.Size = new Size(66, 21);
			label2.TabIndex = 18;
			label2.Text = "Context:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(3, 130);
			label1.Name = "label1";
			label1.Size = new Size(47, 21);
			label1.TabIndex = 17;
			label1.Text = "Time:";
			// 
			// btReturn
			// 
			btReturn.BackColor = Color.Lime;
			btReturn.FlatStyle = FlatStyle.Flat;
			btReturn.Font = new Font("Segoe UI", 10F);
			btReturn.ForeColor = SystemColors.ActiveCaptionText;
			btReturn.Location = new Point(445, 254);
			btReturn.Name = "btReturn";
			btReturn.Size = new Size(102, 28);
			btReturn.TabIndex = 16;
			btReturn.Text = "Return";
			btReturn.UseVisualStyleBackColor = false;
			btReturn.Click += btReturn_Click;
			// 
			// txbTime
			// 
			txbTime.Font = new Font("Segoe UI", 10F);
			txbTime.Location = new Point(3, 154);
			txbTime.Name = "txbTime";
			txbTime.ReadOnly = true;
			txbTime.Size = new Size(161, 25);
			txbTime.TabIndex = 14;
			// 
			// txbSubject
			// 
			txbSubject.Font = new Font("Segoe UI", 10F);
			txbSubject.Location = new Point(3, 185);
			txbSubject.Multiline = true;
			txbSubject.Name = "txbSubject";
			txbSubject.ReadOnly = true;
			txbSubject.Size = new Size(436, 97);
			txbSubject.TabIndex = 13;
			// 
			// txbContext
			// 
			txbContext.Font = new Font("Segoe UI", 10F);
			txbContext.Location = new Point(170, 154);
			txbContext.Name = "txbContext";
			txbContext.ReadOnly = true;
			txbContext.Size = new Size(195, 25);
			txbContext.TabIndex = 12;
			// 
			// txbSender
			// 
			txbSender.Font = new Font("Segoe UI", 10F);
			txbSender.Location = new Point(371, 154);
			txbSender.Name = "txbSender";
			txbSender.ReadOnly = true;
			txbSender.Size = new Size(175, 25);
			txbSender.TabIndex = 11;
			// 
			// dgv
			// 
			dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv.Location = new Point(3, 3);
			dgv.MultiSelect = false;
			dgv.Name = "dgv";
			dgv.Size = new Size(543, 124);
			dgv.TabIndex = 10;
			// 
			// CheckSendedUC
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btReturn);
			Controls.Add(txbTime);
			Controls.Add(txbSubject);
			Controls.Add(txbContext);
			Controls.Add(txbSender);
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
		private Button btReturn;
		private TextBox txbTime;
		private TextBox txbSubject;
		private TextBox txbContext;
		private TextBox txbSender;
		private DataGridView dgv;
	}
}
