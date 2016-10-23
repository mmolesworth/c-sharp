using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public class Statement : Expression
	{
	//Members
	
		IExpression mySubject;
		IExpression myCondition;

	//Constructors
		public Statement()
		{
			//PARAMETERLESS CONSTRUCTOR
		}

		public Statement(IExpression subject, IExpression condition)
		{
			mySubject = subject;
			myCondition = condition;
		}		

	//Methods

		
	//Properties
		public IExpression Subject
		{
			get { return mySubject; }
			set { mySubject = value; }
		}

		public IExpression Condition
		{
			get { return myCondition; }
			set { myCondition = value; }
		}

	} //end class

} //end namespace