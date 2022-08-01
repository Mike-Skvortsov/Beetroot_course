using System.Collections.Generic;

namespace Homework30.EF.DataAccess.Entities
{
	public class Orders
	{
		public int Id { get; set; }
		public int ClientId { get; set; }
		public virtual Clients Client { get; set; }
		public virtual ICollection<Products> Products { get; set; }
	}
}
