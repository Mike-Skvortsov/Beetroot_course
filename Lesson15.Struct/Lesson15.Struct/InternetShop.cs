using System;
using System.Collections.Generic;

namespace Lesson15.Struct
{
	partial class Program
	{
		public class InternetShop : IAddClient, IAddProduct, IChangeStatistic
		{

			public InternetShop()
			{
				this.Clients = Array.Empty<Client>();
				this.ProductInShop = Array.Empty<ProductsInShop>();
				this.Statistic = Array.Empty<Dictionary<string, int>>();
			}
			public Dictionary<string, int>[] Statistic;
			public Client[] Clients;
			public ProductsInShop[] ProductInShop;
			public void AddClient(Client client)
			{
				Array.Resize(ref Clients, Clients.Length + 1);
				Clients.SetValue(client, Clients.Length - 1);
			}
			public void AddProduct(ProductsInShop product)
			{
				Array.Resize(ref ProductInShop, ProductInShop.Length + 1);
				ProductInShop.SetValue(product, ProductInShop.Length - 1);
			}
			public void ChangeStatistic(int clientID, int productID)
			{
				var result = new Dictionary<string, int>
				{
					{"client", clientID },
					{"product", productID }
				};
				Array.Resize(ref Statistic, Statistic.Length + 1);
				Statistic.SetValue(result, Statistic.Length - 1);
			}

			public void SellProduct(int productID, int clientID, string size)
			{
				var itemIndex = -1;
				var clientIndex = -1;
				for (int i = 0; i < this.ProductInShop.Length; i++)
				{
					if (productID == this.ProductInShop[i].id)
					{
						if (this.ProductInShop[i].CountSizes[size] < 1)
						{
							return;
						}
						itemIndex = i;
						break;
					}
				}

				for (int i = 0; i < this.Clients.Length; i++)
				{
					if (clientID == this.Clients[i].Id)
					{
						clientIndex = i;
					}
				}
				if (itemIndex == -1 || clientIndex == -1) return;
				this.ProductInShop[itemIndex].CountSizes[size] -= 1;
				ChangeStatistic(this.Clients[clientIndex].Id, this.ProductInShop[itemIndex].id);
			}
		}
		public interface IAddClient
		{
			void AddClient(Client client);
		}
		public interface IAddProduct
		{
			void AddProduct(ProductsInShop product);
		}

		public interface IChangeStatistic
		{
			void SellProduct(int productID, int clientID, string size);
			void ChangeStatistic(int clientID, int productID);
		}
	}
}