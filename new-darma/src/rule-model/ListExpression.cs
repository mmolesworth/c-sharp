using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public class ListExpression : Expression
	{
	
		List<Expression> expressions = new List<Expression>();

	//Methods
		public override void Visit(IExpressionVisitor visitor)
		{
			visitor.Visit(this);
		}
		
	//Properties

		public List<Expression> Expressions
		{
			get { return expressions; }

			set { expressions = value; }
		}

	} //end class

} //end namespace