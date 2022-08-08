using Homework30.EF.DataAccess;
using Homework30.EF.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework30.EF
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var context = new Shop();
			var count = context.Clients.Count();
			Console.WriteLine(count);
			var client = await context.Clients.Include(x => x.Orders).ToListAsync();
			foreach (var item in context.Employees)
			{
				Console.WriteLine(item.SurName);
			}

			foreach (var Clients in client)
			{
				Console.WriteLine(Clients.FirstName);
			}

			await context.Orders.AddAsync(new Orders
			{
				ClientId = 1,
				Products = new List<Products>
				{
					 new Products { Title = "ps5", Price = 123, Count = 2 },
					 new Products { Title = "xbox", Price = 0, Count = 7 }
				}
			});
			await context.SaveChangesAsync();
			Console.WriteLine(context.Orders.Count());
		}
	}
}
