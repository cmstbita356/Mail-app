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
	public partial class Login : Form
	{
		private readonly MailContext context;
		private readonly UserController usercontroller;
		public Login()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
			context = new MailContext();
			usercontroller = new UserController(context);
		}

		private void btSubmit_Click(object sender, EventArgs e)
		{
			if (usercontroller.Login(txbEmail.Text, txbPassword.Text))
			{
				this.Close();
			}
		}

		private void lbRegister_Click(object sender, EventArgs e)
		{
			Register register = new Register();
			register.Show();
			this.Close();
		}
	}
}
