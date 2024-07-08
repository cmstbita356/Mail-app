using MailApp.Data;
using MailApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MailApp.Controllers
{
	internal class UserController
	{
		private readonly MailContext _context;
        public UserController(MailContext context)
        {
            _context = context;
        }
        public bool Register(string email, string password)
        {
            var user = _context.Users.Where(w => w.Email == email).FirstOrDefault();
            if(user != null)
            {
                return false;
            }
            else
            {
                User u = new User(email, HashPass(password));
                _context.Users.Add(u);
                _context.SaveChanges();
                return true;
            }
        }
        public bool Login(string email, string password)
        {
			var user = _context.Users.Where(w => w.Email == email && w.Password == HashPass(password)).FirstOrDefault();
            if(user != null)
            {
                Properties.Settings.Default.LoggedInEmail = email;
                return true;
            }
            else
            {
                return false;
            }
		}
        public bool LogOut()
        {
            Properties.Settings.Default.LoggedInEmail = string.Empty;
            return true;
        }
		private string HashPass(string password)
        {
			// Convert the input string to a byte array and compute the hash
			using (SHA256 sha256 = SHA256.Create())
			{
				byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

				// Convert the byte array to a hexadecimal string
				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("x2"));
				}
				return builder.ToString();
			}
		}
    }
}
