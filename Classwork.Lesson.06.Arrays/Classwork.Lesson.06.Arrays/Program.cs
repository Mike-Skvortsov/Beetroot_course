using System;

namespace Classwork.Lesson._06.Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int [10];
			int[] arr1 = new[] { 1, 2, 3, 4, 5 };
			int[] arr2 = { 1, 2, 3, 4, 5 };
			arr1[0] = 1;
			Print(arr);

			int i = 0;
			for (i = 0;  i < arr.Length; i++)
			{
				arr[i] = i;
			}

			Print(arr);

			for (i = 0; i < arr.Length; i++)
			{
				arr[i] = i * 2;
			}

			Print(arr);

			var randomArray = GetArray(10);
			Print(randomArray);

			MultipleBy(randomArray, 2);
			Print(randomArray);

			var copiedArray = Copied(randomArray);
			MultipleBy(copiedArray, 10);
			Print(randomArray);
			Print(copiedArray);

			SelectionSort(randomArray);
			Print(randomArray);
		}

		//Сортування Вибіркою(Selection)
		private static void SelectionSort(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				int min = i;
				for (int j = i+1; j < array.Length; j++)
				{
					if (array[j] < array[min])
					{
						min = j;
					}
				}
				int temp = array[min];
				array[min] = array[i];
				array[i] = temp;
			}
		}

		private static int[] Copied(int[] arr)
		{
			int[] copyArray = new int[arr.Length];
			for (int i = 0; i < arr.Length; i++)
			{
				copyArray[i] = arr[i];
			}

			return copyArray;
		}

		private static void Print(int[] arr)
		{
			foreach(var item in arr)
			{
				Console.Write($"{item} ");
			}
			Console.Write(Environment.NewLine);
		}

		private static void MultipleBy(int[] array, int multiplayer)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] *= multiplayer;
			}
		}

		private static int[] GetArray(int length)
		{
			int MaxValue = 100;
			Random random = new Random();
			var array = new int[length];

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = random.Next(-MaxValue, MaxValue);
			}

			return array;
		}

	}
}
