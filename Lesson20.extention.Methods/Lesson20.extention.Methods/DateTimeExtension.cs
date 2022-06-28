using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20.extention.Methods
{
	public static class DateTimeExtension
    {
		// int GetDateBetween(Date date1, DataTime data) -- gets days count
        // int CalculateAge(Date date1) -- age
        // bool IsWorkingDay(DataTime date)
        // bool IsWeekend(DateTime date)
        // IEnumerable<T> ChunkBy(IEnumerable<T> enumerable, int size)
        public static int GetDateBetween(this DateTime date1, DateTime data2) => date1.Subtract(data2).Days;
        public static int CalculateAge(this DateTime date) => DateTime.Now.Month > date.Month ? DateTime.Now.Year - date.Year : DateTime.Now.Year - date.Year - 1;
        public static bool IsWorkingDay(this DateTime date) => date.DayOfWeek != DayOfWeek.Sunday && date.DayOfWeek != DayOfWeek.Saturday;
        public static bool IsWeekend(this DateTime date) => date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday;
        public static IEnumerable<T[]> ChunkBy<T>(this IEnumerable<T> enumerable, int size)
        {
            var array = new T[size];
            int count = 0;
            foreach (T item in enumerable)
            {
                if (count % size != 0 && count == 0)
                {
                    array[count++] = item;
                }
                else
                {
                    yield return array;
                    array = new T[size];
                    count = 0;
                }
            }
        }
    }
}
