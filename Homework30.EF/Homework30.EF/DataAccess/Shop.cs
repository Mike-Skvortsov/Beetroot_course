using Homework30.EF.DataAccess.Entities;
using Homework30.EF.DataAccess.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Homework30.EF.DataAccess
{
	public class Shop : DbContext
	{
		public DbSet<Products> Products { get; set; }
		public DbSet<Clients> Clients { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Orders> Orders { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new ProductMapping());
			base.OnModelCreating(modelBuilder);
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=.;Database=HomeworkShopDB;Trusted_Connection=True;");
		}


	}
}
