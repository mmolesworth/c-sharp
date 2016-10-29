using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public interface IExpressionVisitor
	{
	
	//Methods


	void Visit(ListExpression exp);

	void Visit(OperatorExpression exp);

	void Visit(Statement exp);

	void Visit(Rule exp);

	void Visit(ValueExpression exp);

	void Visit(VariableExpression exp);
	
	String GetResult();
	
	} //end class

} //end namespace