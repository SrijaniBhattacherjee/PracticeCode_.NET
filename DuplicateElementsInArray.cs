using System;
namespace ArraysPractice
{
	public class DuplicateElementsInArray
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

            int[] newArr = new int[size];
            int m = 0;

            // checking for the duplicates
            if (numbers.Length > 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            newArr[m++] = numbers[i];
                        }
                    }
                }
            }

            //checking if the new array has any element
            if (newArr.All(n => n == 0))
            {

                Console.WriteLine("All the elemnts are unique");
            }
            else
            {
                Console.WriteLine("Duplicate Array Elements:");
                foreach (int num in newArr)
                {
                    if (num == 0) continue; 
                    {
                        Console.Write(num + " ");
                    }
                }
            }
        }
    }
}

