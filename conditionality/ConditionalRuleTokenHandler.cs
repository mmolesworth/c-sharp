using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel.Conditionality
{
  	public abstract class TokenHandler
  	{
    		protected TokenHandler successor;
 		

    		public void SetSuccessor(TokenHandler successor)
    		{
      			this.successor = successor;
    		}
 
    		public abstract IExpression HandleToken(String token);

  	} // end TokenHandler class

/*
	public class VariableTokenHandler : TokenHandler
	{
		protected Regex r = new Regex(@"(?<=^([^*\r\n]|\*(?!\*)|\*\*([^*\\\r\n]|\\.|\*(?!\*))*\*\*)*)\w*", RegexOptions.IgnoreCase);

		public override IExpression HandleToken(String token)
		{

			if(r.Match(token).Success)
			{
				return new Expression();
			}
			else
			{
				return this.successor.HandleToken(token);
			}
		}

	} // end AttributeTokenHandler class
*/

	public class InvalidTokenHandler : TokenHandler
	{
		private Regex r = new Regex(@"Sub-group|(IF\s*EXISTS)|(IF\s*Deal)|(IF excess servicing fee deal)|-(?!.)|IF\s*Trust\s*exists|IF\s*applies|IF\s*Available", RegexOptions.IgnoreCase);

		public override IExpression HandleToken(String token)
		{
			if(r.Match(token).Success)
			{
				throw new InvalidTokenException(String.Format("InvalidToken: '{0}'", token));
			}
			else
			{
				return this.successor.HandleToken(token);
			}
		}

	} // end DoNothingTokenHandler

	public class IgnoreTokenHandler : TokenHandler
	{
		private Regex r = new Regex(@"IF");

		public override IExpression HandleToken(String token)
		{
			if(r.Match(token).Success)
			{
				return new IgnoreExpression();
			}
			else
			{
				return this.successor.HandleToken(token);
			}
		}

	} // end DoNothingTokenHandler

	public class OperatorTokenHandler : TokenHandler
	{
		private Regex r = new Regex(@"(=|AND|OR)");

		public override IExpression HandleToken(String token)
		{

			if(r.Match(token).Success)
			{
				return new VariableExpression();
			}
			else
			{
				return this.successor.HandleToken(token);
			}

		}

	} // end OperatorTokenHandler class
	
	public class ValueTokenHandler : TokenHandler
	{
		private Regex r = new Regex(@"""[^""\\]*(?:\\.[^""\\]*)*""");

		public override IExpression HandleToken(String token)
		{

			if(r.Match(token).Success)
			{
				return new ValueExpression(token);
			}
			else
			{
				return this.successor.HandleToken(token);
			}

		}

	} // end ValueTokenHandler class

	public class UnknownTokenHandler : TokenHandler
	{

		public override IExpression HandleToken(String token)
		{
			
			throw new UnknownTokenException(String.Format("'{0}' is not recognized.", token));

		}

	} // end ValueTokenHandler class


} // end namespace
