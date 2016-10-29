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

	//Methods
		public override void Visit(IExpressionVisitor visitor)
		{
			visitor.Visit(this);
		}

	//Properties
		public IFact Fact
		{
			get { return myFact; }
		}


	} //end class

} //end namespace