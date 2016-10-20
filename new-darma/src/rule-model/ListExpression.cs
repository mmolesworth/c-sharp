using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public class ListExpression : Expression
	{
	
		List<Expression> expressions;

	//Methods
		public override String Interpret(IContext c)
		{
			StringBuilder sb = new StringBuilder();

			foreach(IExpression e in expressions)
			{
				sb.Append(e.Interpret(c));
			}
			
			return sb.ToString();

		}
			
	//Properties

		public List<Expression> Expressions
		{
			get { return expressions; }
			set { expressions = value; }
		}

	} //end class

} //end namespace