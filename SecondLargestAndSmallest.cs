using System;
namespace ArraysPractice
{
    public class SecondLargestAndSmallest
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
            // min1 = 2; second max = 6
            //taking two variables
            int smallest = int.MaxValue;
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            if (numbers.Length > 0)
            {
                foreach(var num in numbers)
                {
                    if (num < smallest)
                    {
                        smallest = num;
                    }

                    // find largest and second largest
                    if (num > largest)
                    {
                        secondLargest = largest;
                        largest = num;
                    }
                    else if (num > secondLargest && num != largest)
                    {
                        secondLargest = num;
                    }

                }
                
                Console.WriteLine($"The smallest element of the array: {smallest}");
                Console.WriteLine($"The second largest element of the array: {secondLargest}");
            }
        }
    }
}

