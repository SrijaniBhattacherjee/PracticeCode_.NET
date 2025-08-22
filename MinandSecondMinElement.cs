using System;
namespace ArraysPractice
{
	public class MinandSecondMinElement
	{
		public static void Main(string[] args)
		{
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

            //arr = 2,5,6,3,9
            // min1 = 2; min2 = 3
            //taking two variables
            int min1 = int.MaxValue;
            int min2 = int.MaxValue;

            if(numbers.Length > 0)
            {
                foreach (int num in numbers)
                {
                    if (num < min1)
                    {
                        min2 = min1;
                        min1 = num;
                    }
                    else if (num < min2)
                    {
                        min2 = num;
                    }
                }

                Console.WriteLine($"The minimum element of the array: {min1}");

                if (min2 != int.MaxValue)
                    Console.WriteLine($"The second minimum element of the array: {min2}");
                else
                    Console.WriteLine("There is no distinct second minimum element.");
            }

        }
        
	}
}

