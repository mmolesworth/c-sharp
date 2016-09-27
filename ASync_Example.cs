using System;
using System.IO;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;



class Async_Example
{
    static void Main(string[] args)
    {
    		// You need to add a reference to System.Net.Http to declare client.
    		HttpClient client = new HttpClient();

    		// GetStringAsync returns a Task<string>. That means that when you await the
    		// task you'll get a string (urlContents).
    		Task<string> urlContents = client.GetStringAsync("http://www.washingtonpost.com");

		Console.WriteLine(urlContents.Result);

    }

}
