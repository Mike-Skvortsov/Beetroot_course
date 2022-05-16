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

			string s1 = Console.ReadLine();
			string s2 = Console.ReadLine();
			Console.WriteLine(Compare(s1, s2));

			Analyze(s1);
			Duplicate(s1);
			Console.WriteLine(Sort(s1));
			Console.WriteLine(SoloWork(s1));
		}

		private void Print(string placeholder, string name)
		{
			Console.WriteLine(string.Format(placeholder, name));
		}


		static bool Compare(string str1, string str2)
		{
			if (str1.Length != str2.Length)
			{
				return false;
			}
			for (int i = 0; i <= str1.Length - 1; i++)
			{
				if (str1[i] != str2[i])
				{
					return false;
				}
			}
			return true;
		}

		static void Analyze(string s1)
		{
			int countLetter = 0;
			int countSymbol = 0;
			int countDigit = 0;
			for (int i = 0; i < s1.Length; i++)
			{
				if (char.IsLetter(s1[i]))
				{
					countLetter++;
				}
				if (char.IsDigit(s1[i]))
				{
					countDigit++;
				}
				if (s1[i] == '!' || s1[i] == '@' || s1[i] == '#' || s1[i] == '$' || s1[i] == '%'
				|| s1[i] == '^' || s1[i] == '^' || s1[i] == '&' || s1[i] == '*' || s1[i] == '('
				|| s1[i] == ')' || s1[i] == '_' || s1[i] == '-' || s1[i] == '?' || s1[i] == '/')
				{
					countSymbol++;
				}
			}
			Console.WriteLine("Лiтер : " + countLetter);
			Console.WriteLine("Цифр : " + countDigit);
			Console.WriteLine("Спец. cимволiв : " + countSymbol);
		}

		static string Sort(string str)
		{
			char[] charArray = str.ToLower().ToCharArray();
			string sortArray = "";
			for (int i = 0; i < charArray.Length; i++)
			{
				for (int j = 0; j < charArray.Length - 1; j++)
				{
					if (charArray[j] > charArray[j + 1])
					{
						char temp = charArray[j];
						charArray[j] = charArray[j + 1];
						charArray[j + 1] = temp;
					}
				}
			}
			for (int i = 0; i < charArray.Length - 1; i++)
			{
				sortArray += charArray[i];
			}
			return sortArray;
		}

		static char[] Duplicate(string str)
		{
			char[] Duplicate = str.ToLower().ToCharArray();
			string Dupl = "";
			for (int i = 0; i < str.Length; i++)
			{
				int count = 0;
				for (int j = 0; j < str.Length; j++)
				{
					if (str[i] == str[j])
					{
						count++;
						if (count >= 2)
						{
							if (!Char.IsWhiteSpace(Duplicate[j]) && !Dupl.Contains(Duplicate[i]))
							{
								Dupl += Duplicate[j].ToString();
							}
						}
					}
				}
			}
			char[] arrDupl = Dupl.ToCharArray();
			return arrDupl;
		}

		static string SoloWork(string s1)
		{
			string newStr = "";
			for (int i = 0; i < s1.Length; i++)
			{
				if (s1[i] == s1.ToUpper()[i])
				{
					newStr += s1.ToLower()[i];
				}
				else if (s1[i] == s1.ToLower()[i])
				{
					newStr += s1.ToUpper()[i];
				}
				else
				{
					continue;
				}
			}
			return newStr;
		}
	}
}
