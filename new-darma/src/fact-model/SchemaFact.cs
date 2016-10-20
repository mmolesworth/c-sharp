using System;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.FactModel
{
	public class SchemaFact : Fact
	{
	//Members
		
		SchemaAttribute myAttribute;

	//Constructors

		public SchemaFact()
		{
			//PARAMETERLESS CONSTRUCTOR REQUIRED FOR SERIALIZATION
		}


		public SchemaFact(SchemaAttribute attribute)
		{
			myAttribute = attribute;

		}

	//Properties
		public SchemaAttribute SchemaAttribute
		{ 
			get	{ return myAttribute; }
		}


	//Implemented Properties
		public override string Identifier 
		{ 
			get	{ return myAttribute.CSPID; }
		  	set 	{ /*DO NOTHING */}
		}

		public override string ExternalName
		{ 
			get	{return myAttribute.DataPointName; }
		  	set 	{ /*DO NOTHING*/ }
		}

		public override string Description
		{ 
			get	{return myAttribute.DataElementDefinition; }
		  	set 	{ /*DO NOTHING*/ }
		}

		public override string InternalName
		{ 
			get	{return "NOT MAPPED"; }
		  	set 	{ /*DO NOTHING*/ }
		}

		public override string CommonTerm
		{ 
			get	{return myAttribute.SecuritizationPlatformCommonTerm; }
		  	set 	{ /*DO NOTHING*/ }
		}

	} //end class

} // end namespace
