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

			//print file content
			foreach (var item in content)
			{
				Console.WriteLine(item);
			}
			//(int a, int b) tuple;
			//tuple.a = 100;
			//tuple.b = 30;

			//print Deserialized data
			foreach ((string name, int number) item in Deserialize(content))
			{
				Console.WriteLine($"Name is {item.name}, number is {item.number}");
			}

			var PhoneBook = Deserialize(content);

			var newRecord = (name: "Nick", number: 1212);

			//Add(ref PhoneBook, newRecord);
			//Update(PhoneBook, newRecord, 4);
			Delete(ref PhoneBook, 0);

			//print Serialized data
			var serializedBook = Serialize(PhoneBook);
			foreach (var Var in Serialize(PhoneBook))
			{
				Console.WriteLine(Var);
			}

			File.WriteAllLines(filePath, serializedBook);
		}
		private static(string name, int number) Search ((string name,int number)[] content)
		{

		}
		//private static void Some(string str1) // передаємо копію посилання на кучу. робота з str1
		//{

		//}
		//private static void Some(ref int number) // передаємо посилання на кучу, робота з посиланням
		//{

		//}
		private static void Add(ref (string name, int number)[] content, (string name, int number) newItem)
		{
			var newBook = new (string name, int number)[content.Length + 1];
			content.CopyTo(newBook, 0);
			content.CopyTo(newBook, 0);
			newBook[content.Length] = newItem;
			content = newBook;
		}

		private static void Update((string name, int number)[] content, (string name, int number) updatedItem, int index)
		{
			content[index] = updatedItem;
		}

		private static void Delete(ref (string name, int number)[] content, int index)
		{
			var newBook = new (string name, int number)[content.Length - 1];
			int j = 0;
			for (int i = 0; i < content.Length; i++)
			{
				if (i != index)
				{
					newBook[j++] = content[i];
				}
			}


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
