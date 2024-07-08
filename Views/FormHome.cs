using MailApp.Views;

namespace MailApp
{
	public partial class FormHome : Form
	{
		public FormHome()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
			lbEmail.Text = Properties.Settings.Default.LoggedInEmail;
			timer1.Start();
			Login login = new Login();
			login.Show();

			pictureBox1.BackgroundImage = Properties.Resources.usericon;
		}
		private void ClearUC(Panel p)
		{
			foreach (Control c in p.Controls)
			{
				p.Controls.Remove(c);
			}
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.LoggedInEmail != string.Empty)
			{
				this.Show();
				timer1.Stop();
			}
			else
			{
				this.Hide();
			}
		}

		private void btSended_Click(object sender, EventArgs e)
		{
			ClearUC(panel1);
			CheckSendedUC uc = new CheckSendedUC();
			uc.Dock = DockStyle.Fill;
			panel1.Controls.Add(uc);
		}

		private void btCheck_Click(object sender, EventArgs e)
		{
			ClearUC(panel1);
			CheckMailUC uc = new CheckMailUC();
			uc.Dock = DockStyle.Fill;
			panel1.Controls.Add(uc);
		}


		private void txbSend_Click(object sender, EventArgs e)
		{
			ClearUC(panel1);
			SendMailUC uc = new SendMailUC();
			uc.Dock = DockStyle.Fill;
			panel1.Controls.Add(uc);
		}

		private void btLogout_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.LoggedInEmail = string.Empty;
			Login l = new Login();
			l.Show();
			timer1.Start();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ClearUC(panel1);
			CheckDeletedUC uc = new CheckDeletedUC();
			uc.Dock = DockStyle.Fill;
			panel1.Controls.Add(uc);
		}
	}
}
