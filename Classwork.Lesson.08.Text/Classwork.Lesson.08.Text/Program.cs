using System;
using System.Globalization;
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
			//var newRecord = (name: "Antoni", number: 110008);

			//Add(ref PhoneBook, newRecord);
			//Update(PhoneBook, newRecord, 4);
			//Delete(ref PhoneBook, 0);

			//print Serialized data
			var serializedBook = Serialize(PhoneBook);
			foreach (var Var in Serialize(PhoneBook))
			{
				Console.WriteLine(Var);
			}

			File.WriteAllLines(filePath, serializedBook);
			Sort(PhoneBook);

			//Search(PhoneBook, "1212");
			Console.WriteLine("_______________________________________");
			foreach (var item in PhoneBook)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("_______________________________________");
			var search = BinarySearch(PhoneBook, "An");
			foreach (var item in search)
			{
				Console.WriteLine(item);
			}
		}

		private static (string name, int number)[] BinarySearch((string name, int number)[] content, string search)
		{
			int l = 0;
			int r = content.Length - 1;
			int count = 0;
			(string name, int number)[] newBook = new (string name, int number)[count];
			while (l <= r)
			{
				int midle = l + (r - l) / 2;
				if (content[midle].name.IndexOf(search) != -1)
				{
					Array.Resize(ref newBook, count + 1);
					newBook[count] = content[midle];
					count++;
				}
				if (String.Compare(search, content[midle].name) > 0)
				{
					l = midle + 1;
				}
				else
				{
					r = midle - 1;
				}

			}
			return newBook;
		}


		private static (string name, int number)[] Sort((string name, int number)[] content)
		{
			for (int i = 0; i < content.Length; i++)
			{
				for (int j = 0; j < content.Length; j++)
				{
					if (String.Compare(content[i].name, content[j].name) < 0)
					{
						var temp = content[i];
						content[i] = content[j];
						content[j] = temp;
					}
					else if (String.Compare(content[i].name, content[j].name) == 0)
					{
						if (content[i].number > content[j].number)
						{
							var temp = content[i];
							content[i] = content[j];
							content[j] = temp;
						}
					}
				}
			}
			return content;
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
			Sort(content);
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
