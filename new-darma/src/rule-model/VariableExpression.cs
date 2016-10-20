using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Com.Css.Csp.DataAcceptance.Darma.FactModel;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public class VariableExpression : Expression
	{
	//Members
		IFact myFact;
	
	//Constructors
		public VariableExpression()
		{
			//PARAMETERLESS CONSTRUCTOR
		}

		public VariableExpression(IFact fact)
		{
			myFact = fact;
		}


	//Implemented members
		public override String Interpret(IContext c)
		{
			return "NOT IMPLEMENTED";
		}


	} //end class

} //end namespace