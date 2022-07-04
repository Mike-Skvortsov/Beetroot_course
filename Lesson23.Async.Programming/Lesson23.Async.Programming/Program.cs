using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lesson23.Async.Programming
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var coffee = PourACupOfCoffee();
			var tea = PourACupOfTea();
			Task<string> drink = await Task.WhenAny(coffee, tea);
			Console.WriteLine(drink.Result);
			await HeatUpAPen();

			Task shower = TakeAShower();
			var teeth = BrushMyTeeth();

			await Task.WhenAll(shower, teeth);

			await AddButterToTost().ConfigureAwait(false);
			await AddJamToTost().ContinueWith(x => Console.WriteLine($"Task the end with status {x.Status}"));
			await ScreamAsync();
			var httpClient = new HttpClient();
			var requestMessage = new HttpRequestMessage
			{
				RequestUri = new Uri("https://foodish-api.herokuapp.com/api")
			};
			var responseMessage = await httpClient.SendAsync(requestMessage);
			var stringResponse = await responseMessage.Content.ReadAsStringAsync();

			var image = JsonConvert.DeserializeObject<ImageResponce>(stringResponse);
			Console.WriteLine(stringResponse);
			Console.WriteLine($"got image with url {image!.Image}");
			var imageResponse = await httpClient.SendAsync(new HttpRequestMessage
			{
				RequestUri = new Uri(image.Image)
			});
			await using var stream = await imageResponse.Content.ReadAsStreamAsync();
			await using var fileStream = File.Create("food.jpg");
			stream.Seek(0, SeekOrigin.Begin);
			await stream.CopyToAsync(fileStream);
		}

		private class ImageResponce
		{
			public string Image { get; set; }
		}

		private static void Scream()
		{
			Console.WriteLine("AAAAAAAAAAAAAAAAAAA");
		}
		private static Task ScreamAsync()
		{
			return Task.Run(() => Scream());
		}

		public static async Task<string> PourACupOfCoffee()
		{
			await Task.Delay(1000);
			return "Coffee";
		}
		public static async Task<string> PourACupOfTea()
		{
			await Task.Delay(2000);
			return "Tea";
		}
		public static async Task HeatUpAPen()
		{
			await Task.Delay(1000);
			Console.WriteLine("Griemo");
		}
		public static async Task TakeAShower()
		{
			await Task.Delay(1000);
			Console.WriteLine("Shower");
		}
		public static async Task BrushMyTeeth()
		{
			await Task.Delay(1000);
			Console.WriteLine("Brush teeth");
		}
		public static async Task AddButterToTost()
		{
			await Task.Delay(1000);
			Console.WriteLine("Butter");
		}
		public static async Task AddJamToTost()
		{
			await Task.Delay(1000);
			Console.WriteLine("Add jam");
		}
	}
}
