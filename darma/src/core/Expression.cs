using System;
using System.IO;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Text;


public interface IExpression
{	

	IFactType 	Fact 	{ get; set; }
	IOperator 	Op 	{ get; set; }
	string 		Value 	{ get; set; }

}


class BaseExpression : IExpression
{
	
	//Constructors
	public BaseExpression(){}
	
	public BaseExpression(IFactType fact, IOperator op, string value){
			
		this.Fact = fact;
		this.Op = op;
		this.Value = value;

	}	

	//Properties
	public IFactType Fact 	{ get; set; }
	public IOperator Op 	{ get; set; }
	public string 	Value 	{ get; set; }

}

class ConditionExpression : IExpression
{
	
	//Constructors
	public ConditionExpression(){}
	
	public ConditionExpression(IFactType fact, IOperator op, string value){
			
		this.Fact = fact;
		this.Op = op;
		this.Value = value;

	}	

	//Properties
	public IFactType Fact 	{ get; set; }
	public IOperator Op 	{ get; set; }
	public string 	Value 	{ get; set; }

}
