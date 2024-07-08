using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailApp.Models
{
	internal class Mail
	{
		public int Id { get; set; }
		public string Sender { get; set; }
		public string Receiver { get; set; }
		public string Subject { get; set; }
		public string Context { get; set; }
		public DateTime Time { get; set; }
		public string Status { get; set; }
		public bool IsDeleted { get; set; }
   //     public Mail(string sender, string receiver, string subject, string context, DateTime time, string status, bool isdeleted)
   //     {
			//Sender = sender;
			//Receiver = receiver;
			//Subject = subject;
			//Context = context;
			//Time = time;
			//Status = status;
			//IsDeleted = isdeleted;
   //     }
    }
}
