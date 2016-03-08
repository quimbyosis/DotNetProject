using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetLimber.Models
{
    public class PersonContext : DbContext 
    {
		public DbSet<Person> Persons { get; set; }

		public PersonContext()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			var connectionString = @"Server=(LocalDb)\MSSQLLocalDb;Database=DotNetLimber";
			optionsBuilder.UseSqlServer(connectionString);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ForSqlServerUseIdentityColumns();
		}
	}
}
