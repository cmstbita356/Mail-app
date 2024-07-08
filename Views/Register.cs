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
	public partial class Register : Form
	{
		private readonly MailContext _context;
		private readonly UserController _userController;
		public Register()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
			_context = new MailContext();
			_userController = new UserController(_context);
		}

		private void btSubmit_Click(object sender, EventArgs e)
		{
			if (txbPassword.Text == txbRePassword.Text)
			{
				if (_userController.Register(txbEmail.Text, txbPassword.Text))
				{
					Login login = new Login();
					login.Show();
					this.Close();
				}
			}
		}

		private void lbLogin_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			this.Close();
		}
	}
}
