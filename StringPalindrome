using System;
					
public class Program
{
	public static void Main()
	{	
		//string has been taken 
		string nameStr  = "Heloow";
		char[] charStr = nameStr.ToCharArray();
		string oldReversed = "";
		
		int len = charStr.Length;
		int i = 1;
		
		foreach(var c in charStr){
			char str = charStr[len-i];
			i++;
			oldReversed+=str;
		}
		
		if (oldReversed == nameStr){
			Console.WriteLine("This is a Palindrome");
		}
		else {
			Console.WriteLine("Not a Palindrome");
		}
	}
}
