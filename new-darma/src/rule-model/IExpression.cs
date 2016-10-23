using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public interface IExpression
	{
	
	//Methods
		
		void Visit(IExpressionVisitor visitor);
		
	} //end class

} //end namespace