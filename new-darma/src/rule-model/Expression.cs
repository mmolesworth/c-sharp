using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public abstract class Expression : IExpression
	{
	
	//Methods
		public abstract String Interpret(IContext c);
			
	//Properties



	} //end class

} //end namespace