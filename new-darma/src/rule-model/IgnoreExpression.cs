
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public class IgnoreExpression : Expression
	{
		private String _symbol;

	//Constructors
		public IgnoreExpression()
		{
			//KEEP PARAMTERLESS CONSTRUCTOR
		}

		public IgnoreExpression(String symbol)
		{
			_symbol = symbol;
		}

	//Implemented members
		public override void Visit(IExpressionVisitor visitor)
		{
			
		}
	

	} //end class

} //end namespace