using System;

namespace ArraySorter3
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] array = { 800, 11, 50, 771, 649, 770, 240, 9, 342, 999, 2, 1001, 3245, 89, 23, 198 };

			Sort3(array);

			foreach (var item in array)
			{
				Console.WriteLine(item);
			}

			Console.ReadLine();
		}

		static void Sort3(int[] intArray)
		{
			int temp, j;
			for (int i = 1; i < intArray.Length; i++)
			{
				temp = intArray[i];
				j = i - 1;

				while (j >= 0 && intArray[j] > temp)
				{
					intArray[j + 1] = intArray[j];
					j--;
				}

				intArray[j + 1] = temp;
			}
		}
	}
}