using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public class OperatorExpression : Expression
	{
	//Members
		
	//Implemented members
		public override void Visit(IExpressionVisitor visitor)
		{
			visitor.Visit(this);
		}

	
	//Properties
		public String Symbol
		{
			get {return Symbol; }

			set {Symbol = value; }
		}

		public String SymbolTranslation
		{

			get { return SymbolTranslation; }
			
			set { SymbolTranslation = value; }
		}

		
							
	} //end class

} //end namespace