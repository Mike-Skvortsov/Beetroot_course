using System;
using System.Text;
namespace Classwork.Lesson07.Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = "Name";
			string hisName = "Nick";
			string placeholder = "Hello, {0} and {1}";

			Console.WriteLine($"Hello {name} {hisName}");
			Console.WriteLine(string.Format("Hello {0} {1}", name, hisName));	
			Console.WriteLine(string.Format(placeholder, name, hisName));
			var hello = $"Hello, {name}, {hisName}";
			char symbol = hello[5];

			for (int i = 0; i < hello.Length; i++)
			{
				Console.WriteLine(hello[i]);
			}

			Console.WriteLine(string.Concat("string", " ", "string"));
			Console.WriteLine(hello.Contains('H'));
			Console.WriteLine(hello.Contains('s'));
			Console.WriteLine(hello.Insert(0, "Some text"));
			Console.WriteLine(hello.Remove(7));
			Console.WriteLine(hello.Replace(name, hisName));
			Console.WriteLine(hello.ToLower());

			Console.WriteLine(hello.Trim());
			foreach(var item in hello.Split(","))
			{
				Console.WriteLine(item);
			}
			int N = 1000;
			Console.WriteLine(1.CompareTo(2)); //-1
			Console.WriteLine(2.CompareTo(2)); //0
			Console.WriteLine(3.CompareTo(2)); //1
			Console.WriteLine(string.Equals("abc", "abc"));
			Console.WriteLine(string.Equals("abc", "abc"));
			var emptyString = string.Empty;

			for (int i = 0; i < N; i++)
			{
				emptyString += $"{i}";
			}

			Console.WriteLine(emptyString);
			var stringBuilder = new StringBuilder();

			for (int j = 0; j < N; j++)
			{
				stringBuilder.AppendFormat("{0}", j);
			}
		}

		private void Print(string placeholder, string name)
		{
			Console.WriteLine(string.Format(placeholder, name));
		}
	}
}
