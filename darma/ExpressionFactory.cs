using System;
using System.IO;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Text;



interface IExpressionFactory
{
	
	IExpression createExpression();

}

public class BaseExpressionFactory:IExpressionFactory
{
	
	public IExpression createExpression()
	{
		return new BaseExpression();
	}

}

public class ConditionExpressionFactory:IExpressionFactory
{
	
	public IExpression createExpression()
	{
		return new ConditionExpression();
	}

}

