using System;
using System.IO;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;



namespace SHA1Sample
{
    class Program
    {
        static void Main(string[] args)
        {
	    string source;

	    do {
		
		Console.WriteLine("To quit, type 'q'");
	    	Console.WriteLine("Enter value to compute SHA1 Hash:");
            	source = Console.ReadLine();

		if(source == "q"){
			break;
		}

            	using (SHA1 sha1Hash = SHA1.Create())
            	{
                	string hash = GetSHA1Hash(sha1Hash, source);

                	Console.WriteLine("The SHA1 hash of " + source + " is: " + hash + ".");
			Console.WriteLine("");

            	}

	    } while (source != "exit");

        }

        static string GetSHA1Hash(SHA1 sha1Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

    }
}
