using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public interface IExpressionVisitor
	{
	
	//Methods

	String Visit(IExpression exp);
	
	//Properties



	} //end class

} //end namespace