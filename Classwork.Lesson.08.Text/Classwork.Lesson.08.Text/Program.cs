using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Classwork.Lesson._08.Text
{
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = "PhoneBook.csv";
			string[] content = File.ReadAllLines(filePath);
			foreach (var item in content)
			{
				Console.WriteLine(item);
			}
			//(int a, int b) tuple;
			//tuple.a = 100;
			//tuple.b = 30;

			foreach ((string name, int number) item in Deserialize(content))
			{
				Console.WriteLine($"Name is {item.name}, number is {item.number}");
			}

			var PhoneBook = Deserialize(content);

			PhoneBook[1].number = 234124166;
			var serializedBook = Serialize(PhoneBook);
			foreach (var Var in Serialize(PhoneBook))
			{
				Console.WriteLine(Var);
			}

			File.WriteAllLines(filePath, serializedBook);
		}

		private static string[] Serialize((string name, int number)[] content)
		{
			var strings = new string[content.Length];
			for (int i = 0; i < content.Length; i++)
			{
				strings[i] = $"{content[i].name};{content[i].number}";
			}

			return strings;
		}
		private static (string name, int number)[] Deserialize(string[] content)
		{
			var regexp = new Regex(@"^(\w+);(\d+)$");
			var book = new (string name, int number)[content.Length];
			for (int i = 0; i < content.Length; i++)
			{
				var item = content[i];
				var match = regexp.Match(item); //перевірка співпадіння стрічки і виразу

				if (match.Success)
				{
					book[i].name = match.Groups[1].Value;
					book[i].number = int.Parse(match.Groups[2].Value);
				}
			}
			return book;
		}

	}
}
