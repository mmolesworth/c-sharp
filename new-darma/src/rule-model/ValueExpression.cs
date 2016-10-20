using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public class ValueExpression : Expression
	{
	//Members
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
		public override string Interpret(IContext c)
		{	
			if(String.IsNullOrEmpty(myValue))
			{
				return "EMPTY VALUE";
			}
			else
			{
				return myValue;
			}
		}

	} //end class

} //end namespace