using Lesson36.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lesson36.DataAccess
{
	public class LessonDataContext : DbContext
	{
		public DbSet<Car> Cars { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseInMemoryDatabase(nameof(LessonDataContext));
			base.OnConfiguring(optionsBuilder);
		}
	}
}
