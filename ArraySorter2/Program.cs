using System;

namespace ArraySorter2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = {800, 11, 50, 771, 649, 770, 240, 9, 342, 999, 2, 1001, 3245, 89, 23, 198};

			Sort2(array);

			foreach (var item in array)
			{
				Console.WriteLine(item);
			}

			Console.ReadLine();
		}

		private static void Sort2(int[] array)
		{
			int temp = 0;

			for (int write = 0; write < array.Length; write++)
			{
				for (int sort = 0; sort < array.Length - 1; sort++)
				{
					if (array[sort] > array[sort + 1])
					{
						temp = array[sort + 1];
						array[sort + 1] = array[sort];
						array[sort] = temp;
					}
				}
			}
		}
	}
}