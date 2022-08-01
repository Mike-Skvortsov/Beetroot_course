using System.Collections.Generic;

namespace Homework30.EF.DataAccess.Entities
{
	public class Clients
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public virtual ICollection<Orders> Orders { get; set; }

	}
}
