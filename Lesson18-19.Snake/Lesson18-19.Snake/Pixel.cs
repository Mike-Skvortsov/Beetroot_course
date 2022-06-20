using System;

namespace Lesson18_19.Snake
{
	public struct Pixel
	{
		private const char Border = '█';
		public Pixel(int x, int y, ConsoleColor color, int pixelSize = 3)
		{
			this.X = x; 
			this.Y = y;
			this.Color = color;
			this.PixelSize = pixelSize;
		}
		public int PixelSize { get; }
		public int X { get; }
		public int Y { get; }
		public ConsoleColor Color { get; }
		public void Draw()
		{
			Console.ForegroundColor = Color;
			for (int x = 0; x < PixelSize; x++)
			{
				for (int y = 0; y < PixelSize; y++)
				{
					Console.SetCursorPosition(X * PixelSize + x, Y * PixelSize + y);
					Console.Write(Border);
				}
			}
		}
		public void Clear()
		{
			for (int x = 0; x < PixelSize; x++)
			{
				for (int y = 0; y < PixelSize; y++)
				{
					Console.SetCursorPosition(X * PixelSize + x, Y * PixelSize + y);
					Console.Write(" ");
				}
			}
		}
	}
}
