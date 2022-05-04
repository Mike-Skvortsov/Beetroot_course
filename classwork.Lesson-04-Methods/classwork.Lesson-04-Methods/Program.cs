using System;

namespace classwork.Lesson_04_Methods
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine(Sum(10, 20, false));
			Console.WriteLine(IsOdd(11));
			Console.WriteLine(SumNumbers(5, 10));
			if(TryDevide(100, 10, out int result))
			{ 
				Console.WriteLine(result);
			}
			Console.WriteLine(Concat("10", "20", "30", "40"));
			Console.Write(Factorial(5));


		}

		//static int Sum(int a, int b)
		//{
		//	return a + b;
		//}

		static int Sum(int a, int b, bool r = true)
		{
			if (r) return a + b;
			else return a - b;
		}

		static bool IsOdd(int x)
		{
			if (x % 2 == 0) return true;
			else return false;
		}

		static int SumNumbers(int a, int b, int sum = 0)
		{
			if (a != b)
			{
				sum += a;
				a++;
				return SumNumbers(a, b, sum);
			}
			else return sum;
		}

		static bool TryDevide(int a, int b, out int result)
		{
			result = a / b;
			return a % b == 0;
		}

		//static void Concat(string str1, string str2)
		//{
		//	Console.WriteLine($"{str1} and {str2}");
		//}
		//static void Concat(string str1, string str2, string str3)
		//{
		//	Console.WriteLine($"{str1} and {str2} and {str3}");
		//}

		static int Concat(params string[] strings)
		{
			return strings.Length;
		}

		static int Factorial(int a)
		{
			if (a == 1)
			{
				Console.WriteLine($"{nameof(a)} -> {a}");
				return a;
			}
			return a * Factorial (a-1);
		}

	}
}
