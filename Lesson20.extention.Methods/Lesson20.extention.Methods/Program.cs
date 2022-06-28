using System;

namespace Lesson20.extention.Methods
{
	class Program
	{
		static void Main(string[] args)
		{
			var str1 = "this is my string";
			Console.WriteLine(str1.WordCount());
			Console.WriteLine("ronmwc".ToBool());
			Console.WriteLine("true".ToBool());
		}

		public static int WordCount(string str)
		{
			return str.Split(new char[] { ' ', '.', '?', '!' },
				StringSplitOptions.RemoveEmptyEntries).Length;
		}

	}

	public static class StringExtensions
	{
		public static int WordCount(this string str)
		{
			return str.Split(new char[] { ' ', '.', '?', '!' },
				StringSplitOptions.RemoveEmptyEntries).Length;
		}

		public static bool ToBool(this string str)
		{
			return bool.TryParse(str, out bool value) ? value : false;
		}
	}
}
