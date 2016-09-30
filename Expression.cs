using System;
using System.IO;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Text;



class Expression
{
	
	//Constructors
	public Expression(){}
	
	public Expression(FactType fact, Operator op, string value){
			
		this.Fact = fact;
		this.Op = op;
		this.Value = value;

	}	

	//Properties
	public FactType Fact 	{ get; set; }
	public Operator Op 	{ get; set; }
	public string 	Value 	{ get; set; }

}