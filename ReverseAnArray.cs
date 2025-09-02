using System;
namespace ArraysPractice
{
    public class ReverseAnArray
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

            // arr 1 = {1,2,3,4,5} ; new arr = {5,4,3,2,1}

            int[] newNumbers = new int[size];


            int j = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                newNumbers[j++] = numbers[i];
            }

            Console.WriteLine("The reverse array is : ");
            foreach (int num in newNumbers)
            {
                Console.Write(num + ",");

            }

        }

        // without creating a new array reverses

        //public class ReverseArrayForLoop
        //{
        //    public static void Main(string[] args)
        //    {
        //        int[] numbers = { 1, 2, 3, 4, 5 };

        //        for (int i = 0; i < numbers.Length / 2; i++)
        //        {
        //            int temp = numbers[i];
        //            numbers[i] = numbers[numbers.Length - 1 - i];
        //            numbers[numbers.Length - 1 - i] = temp;
        //        }

        //        Console.WriteLine("The reversed array is:");
        //        for (int i = 0; i < numbers.Length; i++)
        //        {
        //            Console.Write(numbers[i] + ", ");
        //        }
        //    }
        //}

    }


}

