using System;

namespace ArraySorter1
{
    class Program
    {
		static void Main(string[] args)
		{
			int[] array = { 800, 11, 50, 771, 649, 770, 240, 9, 342, 999, 2, 1001, 3245, 89, 23, 198 };

			Sort1(array);

			foreach (var item in array)
			{
				Console.WriteLine(item.ToString());
			}

			Console.ReadLine();
		}

		static void Sort1(int[] array)
		{
			Sort1(array, 0, array.Length - 1);
		}

		static void Sort1(int[] array, int start, int end)
		{
			if (start >= end)
			{
				return;
			}

			int num = array[start];

			int i = start, j = end;

			while (i < j)
			{
				while (i < j && array[j] > num)
				{
					j--;
				}

				array[i] = array[j];

				while (i < j && array[i] < num)
				{
					i++;
				}

				array[j] = array[i];
			}

			array[i] = num;
			Sort1(array, start, i - 1);
			Sort1(array, i + 1, end);
		}
	}


}