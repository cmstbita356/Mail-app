using MailApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailApp.Data
{
	public class MailContext : DbContext
	{
		public MailContext()
		{
		}

		public MailContext(DbContextOptions<MailContext> options) : base(options)
        {
            
        }
		internal DbSet<Mail> Mails { get; set; }
		internal DbSet<User> Users { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=.\\BITA;Initial Catalog=Mail;Integrated Security=True;Trust Server Certificate=True");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Mail
			modelBuilder.Entity<Mail>(e =>
			{
				e.HasKey(k => k.Id);
			});

			// User
			modelBuilder.Entity<User>(e =>
			{
				e.HasKey(k => k.Email);
			});
		}
	}
}
