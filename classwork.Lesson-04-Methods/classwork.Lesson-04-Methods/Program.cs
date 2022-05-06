using System;

namespace classwork.Lesson_04_Methods
{
	class Program
	{
		static void Main()
		{
			//Console.WriteLine(Sum(10, 20, false));
			//Console.WriteLine(IsOdd(11));
			//Console.WriteLine(SumNumbers(5, 10));
			//if(TryDevide(100, 10, out int result))
			//{ 
			//	Console.WriteLine(result);
			//}
			//Console.WriteLine(Concat("10", "20", "30", "40"));
			//Console.Write(Factorial(5));
			Console.WriteLine(MinNumber(5, 13, 8, -5));
			Console.WriteLine(MaxNumber(5, 13, 8, -5));
			Console.WriteLine(TrySumIfOdd(5, 7, out int sum));
			Console.WriteLine(Repeat("and", 5));

		}

		//static int Sum(int a, int b)
		//{
		//	return a + b;
		//}

		//static int Sum(int a, int b, bool r = true)
		//{
		//	if (r) return a + b;
		//	else return a - b;
		//}

		//static bool IsOdd(int x)
		//{
		//	if (x % 2 == 0) return true;
		//	else return false;
		//}

		//static int SumNumbers(int a, int b, int sum = 0)
		//{
		//	if (a != b)
		//	{
		//		sum += a;
		//		a++;
		//		return SumNumbers(a, b, sum);
		//	}
		//	else return sum;
		//}

		//static bool TryDevide(int a, int b, out int result)
		//{
		//	result = a / b;
		//	return a % b == 0;
		//}

		//static void Concat(string str1, string str2)
		//{
		//	Console.WriteLine($"{str1} and {str2}");
		//}
		//static void Concat(string str1, string str2, string str3)
		//{
		//	Console.WriteLine($"{str1} and {str2} and {str3}");
		//}

		//static int Concat(params string[] strings)
		//{
		//	return strings.Length;
		//}

		//static int Factorial(int a)
		//{
		//	if (a == 1)
		//	{
		//		Console.WriteLine($"{nameof(a)} -> {a}");
		//		return a;
		//	}
		//	return a * Factorial (a-1);
		//}

		//					Homework
		//Метод, який повертає максимальне значення серед усіх параметрів
		//…мінімальне значення…
		//Метод TrySumIfOdd, який приймає 2 параметри і повертає true, якщо сума чисел між входами непарна, інакше false, сума повертається як вихідний параметр
		//Перевантажте перші два методи 3 і 4 параметрами
		//Додатково:

		//Визначте та викликайте з різними параметрами наступні методи:

		//Метод Repeat, який приймає рядок X і число N і повертає X, повторений N разів(наприклад, Repeat(‘str’, 3) повертає ‘strstrstr’ = ‘str’ тричі)

		static int MinNumber(params int[] numbers)
		{
			int min = numbers[numbers.Length-1];
				for (int j = numbers.Length-1; j <= 0; j--)
				{
					if(numbers[j] < numbers[j-1])
					{
						min = numbers[j];
					}
				}
			return min;
		}

		static double MinNumber(double a, double b, double c)
		{
			if (a < b && a < c)
			{
				Console.Write("MIN : ");
				return a;
			}
			else if (b < c && b < a)
			{
				Console.Write("MIN : ");
				return b;
			}
			else
			{
				Console.Write("MIN : ");
				return c;
			}
		}
		static double MinNumber(double a, double b, double c, double d)
		{
			if (a < b && a < c && a < d)
			{
				Console.Write("MIN : ");
				return a;
			}
			else if (b < c && b < a && b < d)
			{
				Console.Write("MIN : ");
				return b;
			}
			else if (d < a && d < b && d < c)
			{
				Console.Write("MIN : ");
				return d;
			}
			else
			{
				Console.Write("MIN : ");
				return c;
			}
		}

		static int MaxNumber(params int[] numbers)
		{
			int max = numbers[0];
			for (int j = 1; j < numbers.Length-1; j++)
			{
				if (numbers[j] > numbers[j - 1])
				{
					max = numbers[j];
				}
			}
			return max;
		}

		static double MaxNumber(double a, double b, double c)
		{
			if (a > b && a > c)
			{
				Console.Write("MAX : ");
				return a;
			}
			else if (b > c && b > a)
			{
				Console.Write("MAX : ");
				return b;
			}
			else
			{
				Console.Write("MAX : ");
				return c;
			}
		}
		static double MaxNumber(double a, double b, double c, double d)
		{
			if (a > b && a > c && a > d)
			{
				Console.Write("MAX : ");
				return a;
			}
			else if (b > c && b > a && b > d)
			{
				Console.Write("MAX : ");
				return b;
			}
			else if (d > a && d > b && d > c)
			{
				Console.Write("MAX : ");
				return d;
			}
			else
			{
				Console.Write("MAX : ");
				return c;
			}
		}

		static bool TrySumIfOdd(int firstNumber, int secondNumber, out int sum)
		{
			sum = 0;
			for (int i = ++firstNumber; i < secondNumber; i++)
			{
				sum += i;
			}
			return sum % 2 == 0;
		}

		static string Repeat(string str, int N)
		{
			string new_STR = "";
			for (int i = 0; i < N; i++)
			{
				new_STR += str;
			}
			return new_STR;
		}
	}
}
