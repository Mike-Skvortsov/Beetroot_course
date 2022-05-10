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

			for (int i = 0;  i < arr.Length; i++)
			{
				arr[i] = i;
			}

			Print(arr);

			for (int i = 0; i < arr.Length; i++)
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

			//SelectionSort(randomArray);
			//BubbleSort(randomArray);
			//InsertionSort(randomArray);
			Sort(randomArray, SortAlgorithmType.BubbleSort, OrderBy.Desc);
			Print(randomArray);

		}

		enum OrderBy
		{
			Asc,
			Desc
		}

		enum SortAlgorithmType
		{
			SelectionSort,
			BubbleSort,
			InsertionSort
		}

		private static void Sort(int[] arr, SortAlgorithmType type, OrderBy order)
		{
			switch(type)
			{
				case SortAlgorithmType.BubbleSort:
					{
						BubbleSort(arr, order);
					}
					break;
				case SortAlgorithmType.InsertionSort:
					{
						InsertionSort(arr, order);
					}
					break;
				case SortAlgorithmType.SelectionSort:
					{
						SelectionSort(arr, order);
					}
					break;
			}
		}
		

		//Сортування Вибіркою(Selection)
		private static void SelectionSort(int[] array, OrderBy order)
		{
			for (int i = 0; i < array.Length; i++)
			{
				int min = i;
				for (int j = i+1; j < array.Length; j++)
				{
					switch(order)
					{
						case OrderBy.Desc:
							if (array[j] > array[min])
							{
								min = j;
							}
							break;
						case OrderBy.Asc:
							if (array[j] < array[min])
							{
								min = j;
							}
							break;
					}

				}
				int temp = array[min];
				array[min] = array[i];
				array[i] = temp;
			}
		}

										//Homework
		//Вставка
		// > спадання
		private static void InsertionSort(int[] array, OrderBy order)
		{
			int j;
			for (int i = 1; i < array.Length; i++)
			{
				int min = array[i];
				j = i - 1;
				switch (order)
				{
					case OrderBy.Asc:
						while (j >= 0 && array[j] > min)
						{
							array[j + 1] = array[j];
							j--;
						}
						array[j + 1] = min;
						break;
					case OrderBy.Desc:
						while (j >= 0 && array[j] < min)
						{
							array[j + 1] = array[j];
							j--;
						}
						array[j + 1] = min;
						break;
				}
			}
		}

		//Бульбашкою
		private static void BubbleSort(int[] array, OrderBy order)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array.Length; j++)
				{
					switch (order)
					{
						case OrderBy.Asc:
							if (array[i] < array[j])
							{
								int temp = array[j];
								array[j] = array[i];
								array[i] = temp;

							}
							break;
						case OrderBy.Desc:
							if (array[i] > array[j])
							{
								int temp = array[j];
								array[j] = array[i];
								array[i] = temp;

							}
							break;
					}
				}
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
