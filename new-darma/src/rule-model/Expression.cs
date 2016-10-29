using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public abstract class Expression : IExpression
	{

	//Methods
		
		public abstract void Visit(IExpressionVisitor visitor);
		
			
	//Properties



	} //end class

} //end namespace