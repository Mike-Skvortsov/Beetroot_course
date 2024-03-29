﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson._29.EF.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lesson._29.EF
{
	public static class Program
	{
		public static async Task Main()
		{
			var context = new ShopDataContext();
			var count = context.Categories.Count();

			var categories = await context.Categories.Include(x => x.Products).ToListAsync();

			foreach (var category in categories)
			{
				Console.WriteLine($"Products in category {category.Title}");
				foreach (var product in category.Products)
				{
					Console.WriteLine($"\t{product.Title}, price {product.Price}");
				}
			}
			await context.Categories.AddAsync(new Category
			{
				Title = "Gaming",
				Products = new List<Product>
				{
					new Product {Title = "PS5", Price = 123},
					new Product {Title = "xBox", Price = 0}
				}
			});
			await context.SaveChangesAsync();

			var products = await context.Products.Where(x => x.Category.Title == "Gaming").ToListAsync();
			Console.WriteLine("Gaming products");
			foreach(var product in products)
			{
				Console.WriteLine(product.Title);
			}
		}
	}
}
