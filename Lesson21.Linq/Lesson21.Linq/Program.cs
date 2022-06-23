using System;
using System.Linq;

namespace Lesson21.Linq
{
	class Program
	{
		static void Main(string[] args)
		{
			var array = Enumerable.Range(0, 20).ToArray();
			var newArray = array.Where(x => x % 2 == 0).ToArray();
			foreach (var item in newArray)
			{
				Console.WriteLine(item);
			}
			foreach (var item in array.Select(x => x * 2))
			{
				Console.WriteLine(item);
			}

			var enumerable = from item in array
							 where item % 2 == 0
							 select item * 3;

			foreach (var item in array.Select(x => x * 2))
			{
				Console.WriteLine(item);
			}
			foreach (var item in array.OwnSelect(x => x * 2))
			{
				Console.WriteLine(item);
			}
			array.Any(x => x == 100);
			array.All(x => x < 100);
			array.Take(3);

			foreach (var item in array.Append(40).Append(50))
			{
				Console.WriteLine(item);
			}
			var balls = Enumerable.Range(0, 10).Select(x => new Ball());
			balls.Where(x => x.Color == Color.Green).Select(x => x.Color = Color.Blue).Take(2);
		}
		class Ball
		{
			public Color Color { get; set; }
		}
		enum Color
		{
			Green = 1,
			Blue = 2
		}
	}
}
