using MailApp.Controllers;
using MailApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailApp.Views
{
	public partial class SendMailUC : UserControl
	{
		private readonly MailContext context;
		private readonly MailController mailcontroller;
		public SendMailUC()
		{
			InitializeComponent();
			context = new MailContext();
			mailcontroller = new MailController(context);
		}
		private void ReloadUC()
		{
			txbContext.Text = "";
			txbReceiver.Text = "";
			txbSubject.Text = "";
		}
		private void btSend_Click(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show("Are you sure", "Question", MessageBoxButtons.YesNo);
			if(r == DialogResult.Yes)
			{
				mailcontroller.SendMail(txbReceiver.Text, txbContext.Text, txbSubject.Text, DateTime.Now);
				ReloadUC();
			}
			
			
		}
	}
}
