using System;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.FactModel
{
	[XmlInclude(typeof(SchemaFact))]
	public abstract class Fact : IFact
	{
	
	//Properties
		public abstract string	Identifier 	{ get; set;}

		public abstract string	ExternalName 	{ get; set;}

		public abstract string 	Description 	{ get; set;}

		public abstract string	InternalName	{ get; set;}

		public abstract string	CommonTerm	{ get; set;}

	}

}
