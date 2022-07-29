using Homework30.EF.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework30.EF.DataAccess.Mappings
{
	public class ClientMapping
	{
		public void Configure(EntityTypeBuilder<Clients> builder)
		{
			builder.ToTable("Clients", "dbo");

			builder.HasKey(x => x.Id);
		}
	}
}
