using System;
using System.IO;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Text;



interface IExpressionFactory
{
	
	FactType createFact();
	Operator createOperator();
	string	createValue();

}

public class BaseExpressionFactory:IExpressionFactory
{
	
	public FactType createFact()
	{
	}

	public Operator createOperator()
	{
	}

	public string	createValue()
	{
	}

}

public class ConditionExpressionFactory:IExpressionFactory
{
	
	public FactType createFact()
	{
	}

	public Operator createOperator()
	{
	}

	public string	createValue()
	{
	}

}

