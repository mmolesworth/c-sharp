using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public interface IExpression
	{
	
	//Methods
		
		String Interpret(IContext c);


	} //end class

} //end namespace