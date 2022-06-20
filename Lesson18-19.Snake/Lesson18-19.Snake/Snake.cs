using System;
using System.Collections.Generic;

namespace Lesson18_19.Snake
{
	class Snake
	{
		public Queue<Pixel> BodySnake { get; } = new Queue<Pixel>();
		public ConsoleColor HeadColor { get; }
		public ConsoleColor BodyColor { get; }
		public Pixel Head { get; set; }
		public Snake(int headX, int headY, ConsoleColor headColor, ConsoleColor bodyColor, int bodyLength = 4)
		{
			this.HeadColor = headColor;
			this.BodyColor = bodyColor;

			this.Head = new Pixel(headX, headY, HeadColor);
			for (int i = bodyLength; i >= 0; i--)
			{
				BodySnake.Enqueue(new Pixel(Head.X - i - 1, headY, BodyColor));
			}
			Draw();
		}

		public void Move(Direction direction, bool eat = false)
		{
			Clear();

			BodySnake.Enqueue(new Pixel(Head.X, Head.Y, BodyColor));
			if (!eat)
				BodySnake.Dequeue();


			Head = direction switch
			{
				Direction.Right => new Pixel(Head.X + 1, Head.Y, HeadColor),
				Direction.Left => new Pixel(Head.X - 1, Head.Y, HeadColor),
				Direction.Down => new Pixel(Head.X, Head.Y + 1, HeadColor),
				Direction.Up => new Pixel(Head.X, Head.Y - 1, HeadColor),
				_ => Head
			};
			Draw();
		}
		public void Draw()
		{
			Head.Draw();
			foreach (var pixel in BodySnake)
			{
				pixel.Draw();
			}
		}
		public void Clear()
		{
			Head.Clear();
			foreach (var pixel in BodySnake)
			{
				pixel.Clear();
			}
		}
	}
}
