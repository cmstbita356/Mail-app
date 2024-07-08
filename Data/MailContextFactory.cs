using MailApp.Data;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

public class MailContextFactory : IDesignTimeDbContextFactory<MailContext>
{
	public MailContext CreateDbContext(string[] args)
	{
		var optionsBuilder = new DbContextOptionsBuilder<MailContext>();
		optionsBuilder.UseSqlServer("Data Source=.\\BITA;Initial Catalog=Mail;Integrated Security=True;Trust Server Certificate=True");

		return new MailContext(optionsBuilder.Options);
	}
}