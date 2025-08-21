using System.Transactions;

//took the array size value

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

//enter the element to search
int[] num = new int[1];
Console.WriteLine("Enter the element to search: ");
num[0] = Convert.ToInt32(Console.ReadLine());
int count;

//search for the element
if (numbers.Length > 0 && num.Length > 0)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == num[0])
        {
            count = +i;
            Console.WriteLine($"Number {num[0]} found at position {count}");
            break;
        }
    }
}
else if (num.Length == 0 || numbers.Length == 0)
{
    Console.WriteLine("Please provide the numbers to compare with");
}
else
{
    Console.WriteLine("No match found");
}


