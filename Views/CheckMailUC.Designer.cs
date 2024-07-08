namespace MailApp.Views
{
	partial class CheckMailUC
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
			dgv = new DataGridView();
			txbSender = new TextBox();
			txbContext = new TextBox();
			txbSubject = new TextBox();
			txbTime = new TextBox();
			btRead = new Button();
			btDelete = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
			SuspendLayout();
			// 
			// dgv
			// 
			dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv.Location = new Point(3, 3);
			dgv.MultiSelect = false;
			dgv.Name = "dgv";
			dgv.Size = new Size(543, 124);
			dgv.TabIndex = 0;
			// 
			// txbSender
			// 
			txbSender.Font = new Font("Segoe UI", 10F);
			txbSender.Location = new Point(371, 154);
			txbSender.Name = "txbSender";
			txbSender.ReadOnly = true;
			txbSender.Size = new Size(175, 25);
			txbSender.TabIndex = 1;
			// 
			// txbContext
			// 
			txbContext.Font = new Font("Segoe UI", 10F);
			txbContext.Location = new Point(170, 154);
			txbContext.Name = "txbContext";
			txbContext.ReadOnly = true;
			txbContext.Size = new Size(195, 25);
			txbContext.TabIndex = 2;
			// 
			// txbSubject
			// 
			txbSubject.Font = new Font("Segoe UI", 10F);
			txbSubject.Location = new Point(3, 185);
			txbSubject.Multiline = true;
			txbSubject.Name = "txbSubject";
			txbSubject.ReadOnly = true;
			txbSubject.Size = new Size(436, 97);
			txbSubject.TabIndex = 3;
			// 
			// txbTime
			// 
			txbTime.Font = new Font("Segoe UI", 10F);
			txbTime.Location = new Point(3, 154);
			txbTime.Name = "txbTime";
			txbTime.ReadOnly = true;
			txbTime.Size = new Size(161, 25);
			txbTime.TabIndex = 4;
			// 
			// btRead
			// 
			btRead.Font = new Font("Segoe UI", 10F);
			btRead.Location = new Point(445, 185);
			btRead.Name = "btRead";
			btRead.Size = new Size(102, 28);
			btRead.TabIndex = 5;
			btRead.Text = "Readed";
			btRead.UseVisualStyleBackColor = true;
			btRead.Click += btRead_Click;
			// 
			// btDelete
			// 
			btDelete.BackColor = Color.Red;
			btDelete.FlatStyle = FlatStyle.Flat;
			btDelete.Font = new Font("Segoe UI", 10F);
			btDelete.ForeColor = SystemColors.ButtonHighlight;
			btDelete.Location = new Point(445, 254);
			btDelete.Name = "btDelete";
			btDelete.Size = new Size(102, 28);
			btDelete.TabIndex = 6;
			btDelete.Text = "Deleted";
			btDelete.UseVisualStyleBackColor = false;
			btDelete.Click += btDelete_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(3, 130);
			label1.Name = "label1";
			label1.Size = new Size(47, 21);
			label1.TabIndex = 7;
			label1.Text = "Time:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(170, 130);
			label2.Name = "label2";
			label2.Size = new Size(66, 21);
			label2.TabIndex = 8;
			label2.Text = "Context:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.Location = new Point(371, 130);
			label3.Name = "label3";
			label3.Size = new Size(62, 21);
			label3.TabIndex = 9;
			label3.Text = "Sender:";
			// 
			// CheckMailUC
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btDelete);
			Controls.Add(btRead);
			Controls.Add(txbTime);
			Controls.Add(txbSubject);
			Controls.Add(txbContext);
			Controls.Add(txbSender);
			Controls.Add(dgv);
			Name = "CheckMailUC";
			Size = new Size(550, 285);
			((System.ComponentModel.ISupportInitialize)dgv).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgv;
		private TextBox txbSender;
		private TextBox txbContext;
		private TextBox txbSubject;
		private TextBox txbTime;
		private Button btRead;
		private Button btDelete;
		private Label label1;
		private Label label2;
		private Label label3;
	}
}
