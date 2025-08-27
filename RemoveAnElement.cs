using System;
namespace ArraysPractice
{
	public class RemoveAnElement
	{
		public static void Main(string[] args)
		{
            Console.WriteLine("Enter the size of an array:");
            int size = Convert.ToInt32(Console.ReadLine());

            //initialized the array
            string [] numbers = new string[size];

            //taking the elements of an array
            Console.WriteLine("Enter elements of the array :");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter the element you want to delete: ");
            string? element = Console.ReadLine();

            if(element != "")
            {
                int index = Array.IndexOf(numbers, element);

                if(index == -1)
                {
                    Console.WriteLine("The element is not present in array to remove.");
                }
                else
                {
                    string[] newArr = new string[numbers.Length - 1];

                    int j = 0;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (i == index) continue;
                        {
                            newArr[j++] = numbers[i];
                        }
                    }
                    Console.WriteLine("After deletion the array : ");
                    Console.WriteLine(string.Join(",",newArr));
                }
            }
            else
            {
                Console.WriteLine("Please enter the element to be deleted");
            }
        }
	}
}

