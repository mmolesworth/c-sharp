using System;
using System.Text;


public class PrintCharacterCodes
{

	public static void Main()
	{
		Console.WriteLine("Enter text string:");
		PrintUnicodeCharacterCode(Console.ReadLine());

	}
	
	public static void PrintASCII()
	{
        	for (int i = 0; i <= 255; i++)
         	{
            		System.Console.WriteLine("{0} = {1}", i, (char)i);
         	}

	}



	public static void PrintUnicodeCharacterCode(String input)
	{

		foreach(char c in input)
		{		
			Console.WriteLine("{0}: {1}", c.ToString(), ((int)c).ToString());
		}

			

	}


}