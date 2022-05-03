using System;

namespace Classwork.Lesson_02_Data_Types
{
	class Program
	{
		static void Main(string[] args)
		{
			//byte first = 255;
			//short second = 32000;
			//int third = 999999;
			//long fourth = 9999999; 
			//bool fivth = true;
			//float number_1 = 213.0F; 
			//char symbol = 'I';
			//double number_2 = 23423.14D;
			//decimal big = third + fourth;
			//string str = "Console";
			//float newNumber = number_1 / 2;
			//int money = second* first;

			float x, y;
			Console.Write("enter the value of x : ");
			x = Convert.ToInt32(Console.ReadLine());
			Console.Write("enter the value of y : ");
			y = Convert.ToInt32(Console.ReadLine());
			double Number1 = (-6) * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
			double Number2 = Math.Abs(x) * Math.Sin(x);
			double Number3 = 2 * Math.PI * x;
			double Number4 = Math.Max(x, y);
			Console.WriteLine(Number1);
			Console.WriteLine(Number2);
			Console.WriteLine(Number3);
			Console.WriteLine(Number4);
		}
	}
}
