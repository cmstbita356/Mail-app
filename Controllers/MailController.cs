using MailApp.Data;
using MailApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailApp.Controllers
{
	internal class MailController
	{
		private readonly MailContext _context;
		string email = Properties.Settings.Default.LoggedInEmail;

		public MailController(MailContext context)
        {
			_context = context;
        }
		public List<Mail> CheckMails()
		{
			var mails = _context.Mails.Where(w => w.IsDeleted == false && w.Receiver == email).ToList();
			return mails;
		}
		public List<Mail> GetDeletedMails()
		{
			var mails = _context.Mails.Where(w => w.IsDeleted == true && w.Receiver == email).ToList();
			return mails;
		}
		public List<Mail> GetSendedMails()
		{
			var mails = _context.Mails.Where(w => w.Sender == email).ToList();
			return mails;
		}
		public bool SendMail(string receiver, string context, string subject, DateTime time)
		{
			Mail m = new Mail();
			m.Sender = email;
			m.Receiver = receiver;
			m.Context = context;
			m.Subject = subject;
			m.Time = time;
			m.Status = "";
			m.IsDeleted = false;
			_context.Mails.Add(m);
			_context.SaveChanges();
			return true;
		}
		public Mail FindMailWithId(int id)
		{
			Mail m = _context.Mails.Where(w => w.Id == id).FirstOrDefault();
			return m;
		}
		public bool ChangeStatus(int id)
		{
			Mail m = _context.Mails.Where(w => w.Id == id).FirstOrDefault();
			if (m != null)
			{
				m.Status = "Checked";
				_context.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool DeleteMail(int id)
		{
			Mail m = _context.Mails.Where(w => w.Id == id).FirstOrDefault();
			if (m != null)
			{
				m.IsDeleted = true;
				_context.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool ReturnMail(int id)
		{
			Mail m = _context.Mails.Where(w => w.Id == id).FirstOrDefault();
			if (m != null)
			{
				m.IsDeleted = false;
				_context.SaveChanges();
				return true;
			}
			else
			{
				return false;
			}
		}
    }
}
