using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson._29.EF.DataAccess.Entities
{
	public class Category
	{
		public int Id { get; set; }
		public string Title { get; set; }

		public virtual ICollection<Product> Products { get; set; }
	}
}
