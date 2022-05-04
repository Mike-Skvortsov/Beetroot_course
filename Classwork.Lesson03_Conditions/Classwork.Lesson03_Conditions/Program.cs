using System;

namespace Classwork.Lesson03_Conditions
{
	class Program
	{
		static void Main()
		{
			//int a = 10;
			//int b = 6;

			//if (a < b)
			//{
			//	Console.WriteLine($"{a} is less than {b}");
			//}
			//else
			//{
			//	Console.WriteLine($"{a} is more than {b}");
			//}
			//string s = a > 15 ? "true" : "false";
			//int c = a < b
			//	? a + b
			//	:a - b;

			//var dayOfWeek = 1;
			//switch(dayOfWeek)
			//{
			//	case 1:
			//		Console.WriteLine($"Today is Monday");
			//		break;
			//	case 6:
			//		Console.WriteLine($"Today is Saturday");
			//		break;
			//	default:
			//		Console.WriteLine("another day");
			//		break;
			//}

			//int N = 10;
			//int sum = 0;

			//for (int i = 0; i < N; i++)
			//{
			//	sum += (i % 2 != 0) ? i : 0;
			//}
			//Console.WriteLine($"{sum}");
			//int n = 0;
			//while(true)
			//{
			//	sum += (n % 2 != 0) ? n++ : 0;
			//}
			//var b = Console.ReadLine();
			//var a = Console.ReadLine();
			//var v = Console.ReadLine();
			//int.TryParse(b, out int digit1);
			//int.TryParse(a, out int digit2);
			//int.TryParse(v, out int symbol);

			//switch (symbol)
			//{
			//	case 1:
			//		return digit1 + digit2;
			//	case 2:
			//		return digit1 - digit2;
			//	case 3:
			//		return digit1 * digit2;
			//	case 4:
			//		return digit1 / digit2;
			//	default:
			//		return 0;
			//}


			//						HOMEWORK

			//Task 2
			bool Validity;
			string number;
			Console.Write("Hi, enter your first number: ");
			number = Console.ReadLine();
			Validity = int.TryParse(number, out int X);
			if (Validity == false)
			{
				Console.WriteLine("Invalid input");
				return;
			}
			Console.Write("Hi, enter your second number: ");
			number = Console.ReadLine();
			Validity = int.TryParse(number, out int Y);
			if (Validity == false)
			{
				Console.WriteLine("Invalid input");
				return;
			}
			int sum = 0;
			if (X == Y)
			{
				Console.WriteLine(X);
				return;
			}
			if (X < Y)
			{
				for (int i = X; i <= Y; i++)
				{
					sum += i;
				}
			}
			else if (Y < X)
			{
				for (int i = Y; i <= X; i++)
				{
					sum += i;
				}
			}

			Console.Write(sum);
			//Task 1
			//const int a = 10;
			//const int b = 13;
			//if (a == b)
			//{
			//    Console.Write(a);
			//    return;
			//}
			//for (int i = 0; i <= b; i++)
			//{
			//    sum += i;
			//    if(a==i)
			//    {
			//        Console.Write(sum);
			//        return;
			//    }
			//}
		}

	}
}

