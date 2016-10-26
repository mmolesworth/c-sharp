using System;
using System.Net;
using System.Text;


public class WebDownloadTest
{
	public static void Main()
	{

		Console.WriteLine("Enter URI to downlaod:");
		string remoteUri = Console.ReadLine();
		Console.WriteLine("Enter directory to save file:");
		string fileDirectory = Console.ReadLine();
		
		DownloadFile(remoteUri, fileDirectory);
		
	}
	
	public static void DownloadFile(string uri, string dir)
	{
		Uri myUri = new Uri(uri);
		WebClient myWebClient = new WebClient();
		StringBuilder sb = new StringBuilder();

		int len = myUri.Segments.Length - 1;
		sb.Append(dir);

		string fileName = sb.Append(myUri.Segments[len]).ToString();

		Console.WriteLine("Downloading File \"{0}\".......\n\n", uri);
		myWebClient.DownloadFile(uri,fileName);
		Console.WriteLine("Successfully Downloaded File {0}", uri);

	}
}
