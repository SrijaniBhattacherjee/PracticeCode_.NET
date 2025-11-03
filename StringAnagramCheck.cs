using System;
					
public class Program
{
	public static void Main()
	{	
		//string has been taken 
		string Str1 = "listen";
		string Str2 = "silent";
		
		// making to lower level as to compare equivalent
		Str1.ToLower();
		Str2.ToLower();
		
		// making the char into an array
		char[] ch1 = Str1.ToCharArray();
		char[] ch2 = Str2.ToCharArray();
		
		//sort the char arrays 
		Array.Sort(ch1);
		Array.Sort(ch2);
		
		//compare both the arrays
		string newStr1 = new string(ch1);
		string newStr2 = new string(ch2);
			
		if(newStr1 == newStr2){
			Console.WriteLine("Its an Anagram");
		}else{
			Console.WriteLine("Its not an Anagram");
		}
	}
}
