using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public class RuleDescriptionVisitor : IExpressionVisitor
	{
	//Members
		private String result = "";
		
	
	//Methods

		public void Visit(ListExpression exp)
		{	
			StringBuilder sb = new StringBuilder();

			foreach(Expression e in exp.Expressions)
			{
				RuleDescriptionVisitor v = new RuleDescriptionVisitor ();

				e.Visit(v);
				sb.Append(v.GetResult());

			}

		}

		public void Visit(OperatorExpression exp)
		{

		}

		public void Visit(Statement exp)
		{

		}

		public void Visit(Rule exp)
		{

		}

		public void Visit(ValueExpression exp)
		{

		}

		public void Visit(VariableExpression exp)
		{

		}
	
		public String GetResult()
		{
			return result;
		}


	} //end class

} //end namespace