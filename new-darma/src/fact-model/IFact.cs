using System;
using System.Text;

namespace Com.Css.Csp.DataAcceptance.Darma.FactModel
{
	public interface IFact
	{
	
	//Properties
		string		Identifier 	{ get; set;}
		string		ExternalName 	{ get; set;}
		string 		Description 	{ get; set;}
		string		InternalName	{ get; set;}
		string		CommonTerm	{ get; set;}

	}

}
