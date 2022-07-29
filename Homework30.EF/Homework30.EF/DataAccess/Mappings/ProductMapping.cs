using Homework30.EF.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework30.EF.DataAccess.Mapping
{
	public class ProductMapping : IEntityTypeConfiguration<Products>
	{
		public void Configure(EntityTypeBuilder<Products> builder)
		{
			builder.ToTable("Products", "dbo");

			builder.HasKey(x => x.Id);

			builder
				.HasOne(x => x.Orders)
				.WithMany(x => x.Products)
				.HasForeignKey(x => x.OrderId);
		}
	}
}
