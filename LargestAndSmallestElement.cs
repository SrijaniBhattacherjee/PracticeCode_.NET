using System;
namespace ArraysPractice
{
    public class LargestAndSmallestElement
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


            //arr = {1,2,3,4,5,6}
            //large = 6; seclargest = 5;

            int largest = int.MinValue;
            int smallest = int.MaxValue;

            if (numbers.Length > 0)
            {
                foreach (var num in numbers)
                {
                    if (num > largest)
                    {
                        largest = num;
                    }

                    if(num < smallest)
                    {
                        smallest = num;
                    }
                }

                Console.WriteLine($"The largest element in an array : {largest} ");
                Console.WriteLine($"The smallest element in an array : {smallest} ");
            }
        }
    }
}

