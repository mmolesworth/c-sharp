using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;


namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel.Conditionality
{
	public class ConditionalRuleBuilder
	{
		
		private static ConditionalRuleBuilder instance;
		private TokenHandler firstHandler;

		private ConditionalRuleBuilder()
		{

			//TokenHandler Order: 1.InvalidToken 2.OperatorToken 3.ValueToken 4.IgnoreToken 5.VariableToken 6.UnknownToken
			
			TokenHandler invalidToken = new InvalidTokenHandler();
			TokenHandler operatorToken = new InvalidTokenHandler();
			TokenHandler valueToken = new InvalidTokenHandler();
			TokenHandler ignoreToken = new InvalidTokenHandler();
			TokenHandler variableToken = new InvalidTokenHandler();
			TokenHandler unknownToken = new InvalidTokenHandler();

			invalidToken.SetSuccessor(operatorToken);
			operatorToken.SetSuccessor(valueToken);
			valueToken.SetSuccessor(ignoreToken);
			ignoreToken.SetSuccessor(variableToken);
			variableToken.SetSuccessor(unknownToken);
			
			firstHandler = invalidToken;

	
		}

		public static ConditionalRuleBuilder GetInstance()
		{
			if(instance == null)
			{
				instance = new ConditionalRuleBuilder();
			} 
			
			return instance;
			
		}

		public String Parse(String input)
		{
			// Tokenize

			char[] delimiterChars = { ' ' };

			string[] tokens = input.Split(delimiterChars);

			try
			{
				foreach(string token in tokens)
				{
					IExpression expression = firstHandler.HandleToken(token);
				}
			}	
			catch (Exception e)
			{
				Console.WriteLine(e.Message);

			}

			return "Parse Method is not implemented";

		} // end parse method

		private static Rule BuildRule()
		{
			throw new Exception("Not Built Yet");

		}


	} //end class ConditionalRuleBuilder



} //end namespace