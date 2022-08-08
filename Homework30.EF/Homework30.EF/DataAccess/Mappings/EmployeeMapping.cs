using Homework30.EF.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework30.EF.DataAccess.Mappings
{
	public class EmployeeMapping
	{
		public void Configure(EntityTypeBuilder<Employee> builder)
		{
			builder.ToTable("Employees", "dbo");

			builder.HasKey(x => x.Id);
		}
	}
}
