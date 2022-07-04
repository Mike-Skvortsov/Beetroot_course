using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;

namespace LinqLesson
{
	class Program
	{
		static void Main(string[] args)
		{
			var array = Enumerable.Range(0, 20).ToArray();
			var newArray = array.Where(x => x % 2 == 0).ToArray();
			foreach (var item in newArray)
			{
				Console.WriteLine(item);
			}
			foreach (var item in array.Select(x => x * 2))
			{
				Console.WriteLine(item);
			}

			var enumerable = from item in array
							 where item % 2 == 0
							 select item * 3;

			foreach (var item in array.Select(x => x * 2))
			{
				Console.WriteLine(item);
			}
			foreach (var item in array.OwnSelect(x => x * 2))
			{
				Console.WriteLine(item);
			}
			array.Any(x => x == 100);
			array.All(x => x < 100);
			array.Take(3);

			foreach (var item in array.Append(40).Append(50))
			{
				Console.WriteLine(item);
			}
			var balls = Enumerable.Range(0, 10).Select(x => new Ball());
			balls.Where(x => x.Color == Color.Green).Select(x => x.Color = Color.Blue).Take(2);

			var persons = JsonConvert.DeserializeObject<IEnumerable<Person>>(File.ReadAllText("data.json"));
			var maxAge = persons.Max(x => x.Age);
			var minAge = persons.Min(x => x.Age);
			Console.WriteLine(persons.Where(x => x.IsActive).Count());
			Console.WriteLine(persons.Where(x => x.Gender == Gender.Female).Count());
			Console.WriteLine(persons.Where(x => x.Gender == Gender.Male).Count());
			var average = (int)persons.Average(x => x.Age);
			Console.WriteLine(average);

			Console.WriteLine(persons.Where(x => x.Name == "Rae Butler").Count());

			var First = persons.Min(x => x.Registered);
			Console.WriteLine(persons.FirstOrDefault(x => x.Registered == First).Name);
			var Last = persons.Max(x => x.Registered);
			Console.WriteLine(persons.FirstOrDefault(x => x.Registered == Last).Name);

			var p = persons.Where(x => x.Age == average + 1 || x.Age == average - 1);
			foreach (var item in p)
			{
				Console.WriteLine(item.Name);
			}
			Console.WriteLine("_______________");

			var test = persons.GroupBy(s => s.Company).Where(g => g.Count() != 1);
			foreach (var item in test)
			{
				Console.WriteLine(item.Key);
			}
			var countColor = persons.GroupBy(s => s.EyeColor).Where(g => g.Count() != 1);
			foreach (var item in countColor)
			{
				Console.WriteLine($"Count people with {item.Key} eyes is {item.Count()}");
			}
			var maxFriends = persons.Max(x => x.Friends.Length);
			var friend = persons.GroupBy(s => s.Friends).Where(g => g.Key.Length == maxFriends);

			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
			var balance = persons.Select(x => (x.Name, decimal.Parse(x.Balance, NumberStyles.Currency | NumberStyles.AllowCurrencySymbol, CultureInfo.DefaultThreadCurrentCulture)));
			Console.WriteLine(balance.Select(x => x.Item2).Average());

			Console.WriteLine("___________________________________________");

			var sameFirstName = persons.GroupBy(s => s.Name).Where(g => g.Count() != 1);

			var allTags = persons.GroupBy(x => x.Tags).SelectMany(x => x.Key).ToArray();
			var ourTag = allTags.GroupBy(x => x).OrderBy(x => x.Count()).Select(x => x.Key);
			Console.WriteLine(ourTag.Last());
		}
	}
	class Ball
	{
		public Color Color { get; set; }
	}
	enum Color
	{
		Green = 1,
		Blue = 2
	}
}

