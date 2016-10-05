using System;
using System.Text;

namespace Com.Css.Csp.DataAcceptance.Darma.Model
{

	public interface IExpression
	{	

		string Value { get; set; }

		public string Text { get; }

	}

	public class FactExpression
	{
		IFact myFact;

		public FactExpression();

		public FactExpression(IFact fact)
		{
			myFact = fact;
		}

		public string Text
		{
			get { return "NEED TO IMPLEMENT PROPERTY" }
		}

		string Value { get; set; }

	}

	public class OperatorExpression
	{
		
		string Value { get; set; }

		public string Text
		{
			get { return this.Value; }
		}

	}

	public class ValueExpression
	{

		string Value { get; set; }

		public string Text
		{
			get { return this.Value; }
		}

	}

}