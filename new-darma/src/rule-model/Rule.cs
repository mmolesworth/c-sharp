using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public class Rule : Expression
	{


	//Implemented members
		public override void Visit(IExpressionVisitor visitor)
		{
			visitor.Visit(this);
		}



	} //end class

} //end namespace