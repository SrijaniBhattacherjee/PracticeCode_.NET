using System;
namespace ArraysPractice
{
	public class MaxElementinArray
	{
		public static void Main(string[] args)
		{
            //size of an array taken
            Console.WriteLine("Enter the size of an array:");
            int size = Convert.ToInt32(Console.ReadLine());

            //initialized the array
            int[] numbers = new int[size];

            //taking the elements of an array
            Console.WriteLine("Enter elements of the array :");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (numbers.Length > 0)
            {
                int count = 0;
                Console.WriteLine("Enter the size of an array:");
                int size2 = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[size2];


                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        count += 1;
                    }
                }
                Console.WriteLine($"The total count of even numbers in the array : {count}");
            }
            else
            {
                Console.WriteLine("The array is empty. please provide a value.");
            }
        }
	}
}

