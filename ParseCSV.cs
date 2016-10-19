using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;

public class ParseTest
{

	public static void Main()
	{
		string csv = "2,1016,7/31/2008 14:22,Geoff Dalgas,6/5/2011 22:21,http://stackoverflow.com,\"Corvallis, OR\",7679,351,81,b437f461b3fd27387c5d8ab47a293d35,34";
		//string path = @"C:\Users\[ENTER PATH HERE].csv";

		TextFieldParser parser = new TextFieldParser(new StringReader(csv));
		//TextFieldParser parser = new TextFieldParser(path);

		// You can also read from a file
		// TextFieldParser parser = new TextFieldParser("mycsvfile.csv");

		parser.HasFieldsEnclosedInQuotes = true;
		parser.SetDelimiters(",");

		string[] fields;
		int row = 1;
		
		while (!parser.EndOfData)
		{
			Console.WriteLine();
			Console.WriteLine("Row:{1}", row, parser.LineNumber.ToString());
    			fields = parser.ReadFields();
   			foreach (string field in fields)
    			{
       				Console.WriteLine(field);
    			}
			row += 1;

		} 

		parser.Close();
	}
}
