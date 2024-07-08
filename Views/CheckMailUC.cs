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
	public partial class CheckMailUC : UserControl
	{
		private readonly MailContext context;
		private readonly MailController mailcontroller;
		int selectedid;
		public CheckMailUC()
		{
			InitializeComponent();
			context = new MailContext();
			mailcontroller = new MailController(context);
			dgv.DataSource = mailcontroller.CheckMails();
			dgv.Columns["Id"].Visible = false;
			dgv.Columns["Receiver"].Visible = false;
			dgv.Columns["IsDeleted"].Visible = false;
			dgv.ScrollBars = ScrollBars.Both;
			dgv.MultiSelect = false;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.SelectionChanged += Dgv_SelectionChanged;
			dgv.ReadOnly = true;
		}
		private void ReloadUC()
		{
			dgv.DataSource = null;
			dgv.DataSource = mailcontroller.CheckMails();
			dgv.Columns["Id"].Visible = false;
			dgv.Columns["Receiver"].Visible = false;
			dgv.Columns["IsDeleted"].Visible = false;
		}
		private void Dgv_SelectionChanged(object? sender, EventArgs e)
		{
			if (dgv.SelectedRows.Count != 0)
			{
				DataGridViewRow row = dgv.SelectedRows[0];
				int id = int.Parse(row.Cells["Id"].Value.ToString());
				selectedid = id;
				Mail m = mailcontroller.FindMailWithId(id);
				txbSender.Text = m.Sender;
				txbContext.Text = m.Context;
				txbTime.Text = m.Time.ToString();
				txbSubject.Text = m.Subject;
			}
		}


		private void btRead_Click(object sender, EventArgs e)
		{
			if (selectedid != null)
			{
				if(mailcontroller.ChangeStatus(selectedid))
				{
					MessageBox.Show("Mail Successfully Check");
					ReloadUC();
				}
				else
				{
					MessageBox.Show("Mail can't be Checked");
				}
			}
		}

		private void btDelete_Click(object sender, EventArgs e)
		{
			if (selectedid != null)
			{
				DialogResult r = MessageBox.Show("Are you sure", "Question", MessageBoxButtons.YesNo);
				if (r == DialogResult.Yes)
				{
					if (mailcontroller.DeleteMail(selectedid))
					{
						MessageBox.Show("Mail Successfully delete");
						ReloadUC();
					}
					else
					{
						MessageBox.Show("Mail can't be deleted");
					}
				}
			}
		}
	}
}
