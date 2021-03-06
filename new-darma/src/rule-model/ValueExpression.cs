
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public class ValueExpression : Expression
	{
		String myValue;

	//Constructors
		public ValueExpression()
		{
			//KEEP PARAMTERLESS CONSTRUCTOR
		}

		public ValueExpression(String value)
		{
			myValue = value;
		}

	//Implemented members
		public override void Visit(IExpressionVisitor visitor)
		{
			visitor.Visit(this);
		}
	
	//Properties
		public String Value
		{
			get { return myValue; }

			set { myValue = Value; }
		}

	} //end class

} //end namespace