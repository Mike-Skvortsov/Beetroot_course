using Homework30.EF.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework30.EF.DataAccess.Mappings
{
	public class OrderMapping
	{
		public void Configure(EntityTypeBuilder<Orders> builder)
		{
			builder.ToTable("Orders", "dbo");

			builder.HasKey(x => x.Id);

			builder
				.HasOne(x => x.Client)
				.WithMany(x => x.Orders)
				.HasForeignKey(x => x.ClientId);
		}
	}
}
