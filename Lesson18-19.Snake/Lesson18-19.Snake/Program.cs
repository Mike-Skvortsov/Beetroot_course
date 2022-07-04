using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using static System.Console;

namespace Lesson18_19.Snake
{
	class Program
	{
		private const int width = 30;
		private const int height = 20;

		private const int screenWidth = width * 3;
		private const int screenHeight = height * 3;

		private static readonly Random Random = new Random();
		static void Main()
		{
			SetWindowSize(screenWidth, screenHeight);
			SetBufferSize(screenWidth, screenHeight);
			CursorVisible = false;

			while (true)
			{
				Start();
				ReadKey();
			}
		}

		static void Start()
		{
			Clear();

			FramesBorder();

			Direction currentMove = Direction.Right;

			var snake = new Snake(15, 5, ConsoleColor.Red, ConsoleColor.Green);
			Pixel food = Food(snake);
			food.Draw();
			int score = 0;

			Stopwatch sw = new Stopwatch();

			while (true)
			{
				sw.Restart();

				Direction oldMove = currentMove;

				while(sw.ElapsedMilliseconds <= 200)
				{
					if(currentMove == oldMove)
						currentMove = OurMove(currentMove);
				}
				if (snake.Head.X == food.X && snake.Head.Y == food.Y)
				{
					snake.Move(currentMove, true);
					food = Food(snake);
					food.Draw();
					score++;
				}
				else
				{
					snake.Move(currentMove);
				}

				if (snake.Head.X == width - 1
					|| snake.Head.X == 0
					|| snake.Head.Y == height - 1
					|| snake.Head.Y == 0
					|| snake.BodySnake.Any(b => b.X == snake.Head.X && b.Y == snake.Head.Y))
					break;
			}
			snake.Clear();

			SetCursorPosition(screenWidth / 3, screenHeight / 2);
			WriteLine($"The end, your score is {score}");
		}

		static Pixel Food(Snake snake)
		{
			Pixel food;
			do
			{
				food = new Pixel(Random.Next(1, width - 2), Random.Next(1, height - 2), ConsoleColor.Yellow);
			} while (snake.Head.X == food.X && snake.Head.Y == food.Y || snake.BodySnake.Any(b => b.X == food.X && b.Y == food.Y));
			return food;
		}

		static Direction OurMove(Direction currentDirection)
		{
			 if (!KeyAvailable)
                return currentDirection;

            ConsoleKey key = ReadKey(true).Key;

            currentDirection = key switch
            {
                ConsoleKey.UpArrow when currentDirection != Direction.Down => Direction.Up,
                ConsoleKey.DownArrow when currentDirection != Direction.Up => Direction.Down,
                ConsoleKey.LeftArrow when currentDirection != Direction.Right => Direction.Left,
                ConsoleKey.RightArrow when currentDirection != Direction.Left => Direction.Right,
                _ => currentDirection
            };

            return currentDirection;
        }
		
		static void FramesBorder()
		{
			for (int i = 0; i < width; i++)
			{
				new Pixel(i, 0, ConsoleColor.Blue).Draw();
				new Pixel(i, height - 1, ConsoleColor.Blue).Draw();
			}
			for (int i = 0; i < height; i++)
			{
				new Pixel(0, i, ConsoleColor.Blue).Draw();
				new Pixel(width - 1, i, ConsoleColor.Blue).Draw();
			}
		}
	}
}