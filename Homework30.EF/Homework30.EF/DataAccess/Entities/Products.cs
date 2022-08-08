using Microsoft.EntityFrameworkCore;

namespace Homework30.EF.DataAccess.Entities
{
	public class Products
	{
		public string Title { get; set; }
		public int Id { get; set; }
		public int OrderId { get; set; }
		public float Price { get; set; }
		public int Count { get; set; }
		public virtual Orders Orders { get; set; }

	}
}
