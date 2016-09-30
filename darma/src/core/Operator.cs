using System;
using System.IO;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Text;


public interface IOperator
{
	string Symbol		{ get; set; }
	string Description	{ get; set; }

}


class StandardOperator
{

	public string Symbol { get; set; }
	
	public string Description { get; set;}

}