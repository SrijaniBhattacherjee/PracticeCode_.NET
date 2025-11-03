
using System;
					
public class Program
{
	public static void Main()
	{	
		//string has been taken 
		string nameStr  = "I love programming";
		string space = " ";
		
		string[] arrayStr = nameStr.Split(space);
		
		int length = arrayStr.Length;
		int i = 1;
		
		foreach(var name in arrayStr){
			Console.Write(arrayStr[length-i] + " ");
			i++;
		}
		
	}
}
