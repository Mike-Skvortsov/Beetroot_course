using System.Collections.Generic;

namespace Lesson15.Struct
{
	partial class Program
	{
		public class ProductsInShop
		{
			public string Name { get; set; }
			public int PriceInDollars { get; set; }
			public string Brand { get; set; }
			public string TypeOfClothes { get; set; }
			public Dictionary<string, int> CountSizes { get; set; }
			public string Description { get; set; }

			public int id { get; set; }
			private static int countID = 0;
			public ProductsInShop(string name, int priceInDollars, string brand, string typeOfClothes, Dictionary<string, int> countSizes, string descriprion)
			{
				this.Name = name;
				this.Brand = brand;
				this.PriceInDollars = priceInDollars;
				this.TypeOfClothes = typeOfClothes;
				this.CountSizes = countSizes;
				this.Description = descriprion;
				this.id = ProductsInShop.countID;
				ProductsInShop.countID++;
			}
		}

	}
}