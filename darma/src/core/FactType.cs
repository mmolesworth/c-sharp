using System;
using System.IO;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Text;


public interface IFactType
{
	
	string Signature 		{ get; set; }
	string ID 			{ get; set; }
	string Description		{ get; set; }

}


public class DerivedFactType : IFactType {
	
	public string Signature 	{ get; set; }
	public string ID		{ get; set; }
	public string Description 	{ get; set; }

}

public class ULDDFactType : IFactType{
	
	public string Signature 	{ get; set; }
	public string ID		{ get; set; }
	public string Description 	{ get; set; }

}
