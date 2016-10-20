using System;
using System.Text;

namespace Com.Css.Csp.DataAcceptance.Darma.FactModel
{
	public interface ISchemaAttribute
	{

	//Properties
		string	Interface				{ get; set;}
		string	Version					{ get; set;}
		string	SchemaNames				{ get; set;}
		string	SpecID					{ get; set;}
		string	CSPID					{ get; set;}
		string	XPath					{ get; set;}
		string	ContainerParent				{ get; set;}
		string	SecuritizationPlatformCommonTerm	{ get; set;}
		string	DataPointName				{ get; set;}
		string	DataElementDefinition			{ get; set;}
		string	Conditionality				{ get; set;}
		string	ConditionalityDetails			{ get; set;}
		string	LoanStateType				{ get; set;}
		string	LoanRoleType				{ get; set;}
		string	PartyRoleType				{ get; set;}
		string	InMISMO					{ get; set;}
		string	DataFormat				{ get; set;}
		string	ImplementedXMLType			{ get; set;}
		string	CSPSupportedEnumerations		{ get; set;}
		string	ImplementationNotes			{ get; set;}

	}

}
