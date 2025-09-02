using System;
namespace ArraysPractice
{
	public class SortingAnArray
	{

        // Bubble sort
		public static void Main(string[] args)
		{
            int[] numbers = { 5, 2, 8, 1, 3 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // swap
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
	}
}

