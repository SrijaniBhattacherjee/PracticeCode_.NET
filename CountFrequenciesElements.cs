using System;
namespace ArraysPractice
{
	public class CountFrequenciesElements
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

           //boolean to see if any number is already been checked
            bool[] visited = new bool[numbers.Length];

            for(int i = 0; i < numbers.Length; i++)
            {
                if (visited[i])
                    continue;

                int count = 1;

                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count ++ ;
                        visited[j] = true;
                    }
                }
                Console.WriteLine($"Element {numbers[i]} occurs {count} times");
            }
        }
	}
}

