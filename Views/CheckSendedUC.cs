using MailApp.Controllers;
using MailApp.Data;
using MailApp.Models;
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
	public partial class CheckSendedUC : UserControl
	{
		private readonly MailContext context;
		private readonly MailController mailcontroller;
		public CheckSendedUC()
		{
			InitializeComponent();
			context = new MailContext();
			mailcontroller = new MailController(context);
			dgv.DataSource = mailcontroller.GetSendedMails();
			dgv.Columns["Id"].Visible = false;
			dgv.Columns["Sender"].Visible = false;
			dgv.Columns["IsDeleted"].Visible = false;
			dgv.ScrollBars = ScrollBars.Both;
			dgv.MultiSelect = false;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.SelectionChanged += Dgv_SelectionChanged;
			dgv.ReadOnly = true;
		}

		private void Dgv_SelectionChanged(object? sender, EventArgs e)
		{
			if (dgv.SelectedRows.Count != 0)
			{
				DataGridViewRow row = dgv.SelectedRows[0];
				int id = int.Parse(row.Cells["Id"].Value.ToString());
				Mail m = mailcontroller.FindMailWithId(id);
				txbReceiver.Text = m.Receiver;
				txbContext.Text = m.Context;
				txbTime.Text = m.Time.ToString();
				txbSubject.Text = m.Subject;
			}
		}
	}
}
