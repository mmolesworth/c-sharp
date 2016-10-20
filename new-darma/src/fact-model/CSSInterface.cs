using System;
using System.Text;

namespace Com.Css.Csp.DataAcceptance.Darma.FactModel
{
	public class CSSInterface
	{


	//Constructors

		public CSSInterface() {}

		public CSSInterface(String identifier)
		{
			Identifier 	= identifier;

		}

		public CSSInterface(String identifier, String name)
		{
			Identifier 	= identifier;
			Name 		= name;

		}

		public CSSInterface(String identifier, String name, string description)
		{
			Identifier 	= identifier;
			Name 		= name;
			Description 	= description;

		}	

	//Properties
		public 	string		Identifier 	{ get; set;}
		public	string		Name 		{ get; set;}
		public 	string 		Description 	{ get; set;}

	}

}
