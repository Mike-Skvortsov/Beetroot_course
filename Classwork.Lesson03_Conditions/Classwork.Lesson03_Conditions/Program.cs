using System;

namespace Classwork.Lesson03_Conditions
{
	class Program
	{
		static int Main()
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
			var b = Console.ReadLine();
			var a = Console.ReadLine();
			var v = Console.ReadLine();
			isNum = int.TryParse(b, out int digit1);
			isNum = int.TryParse(a, out int digit2);
			isNum = int.TryParse(v, out int symbol);

			switch (symbol)
			{
				case 1:
					return digit1 + digit2;
				case 2:
					return digit1 - digit2;
				case 3:
					return digit1 * digit2;
				case 4:
					return digit1 / digit2;
				default:
					return 0;
			}

		}
	}
}
