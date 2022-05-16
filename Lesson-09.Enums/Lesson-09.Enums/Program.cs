using System;

namespace Lesson_09.Enums
{

	enum DayOfWeek
	{
		Sunday,
		Monday,
		Tuesday
	}
	class Program
	{
		static void Main(string[] args)
		{
			DayOfWeek day = DayOfWeek.Monday;
			Console.WriteLine($"Today is {day}");

			foreach (var item in Enum.GetValues<DayOfWeek>())
			{
				Console.WriteLine((int)item);
			}

			DayOfWeek newDayOfWeek = (DayOfWeek)15;
			if(newDayOfWeek == DayOfWeek.Monday)
			{

			}
			Console.WriteLine($"Today is {newDayOfWeek}");
		}

		private static string GetHoliday(DayOfWeek dayOfWeek)
		{
			switch (dayOfWeek)
			{
				case DayOfWeek.Monday:
				case DayOfWeek.Tuesday:
					return "non-holiday";
				case DayOfWeek.Sunday:
					return "holiday";
			}
			return string.Empty;
		}
	}
}
