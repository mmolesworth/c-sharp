using System;
using System.Text;

namespace Com.Css.Csp.DataAcceptance.Darma.FactModel
{
	public class SchemaAttribute : ISchemaAttribute
	{

	//Constructors

		public SchemaAttribute() 
		{
			Initialize();

		}
		
		public SchemaAttribute(string cspID, string dataPointName, string definition)
		{
			Initialize();

			CSPID = cspID;
			DataPointName = dataPointName;
			DataElementDefinition = definition;
		}

	//Methods
		private void Initialize()
		{
			Interface				= string.Empty;
			Version					= string.Empty;
			SchemaNames				= string.Empty;
			SpecID					= string.Empty;
			CSPID					= string.Empty;
			XPath					= string.Empty;
			SecuritizationPlatformCommonTerm	= string.Empty;
			DataPointName				= string.Empty;
			DataElementDefinition			= string.Empty;
			Conditionality				= string.Empty;
			ConditionalityDetails			= string.Empty;
			LoanStateType				= string.Empty;
			LoanRoleType				= string.Empty;
			PartyRoleType				= string.Empty;
			InMISMO					= string.Empty;
			DataFormat				= string.Empty;
			ImplementedXMLType			= string.Empty;
			CSPSupportedEnumerations		= string.Empty;
			ImplementationNotes			= string.Empty;
		}

	//Properties
		public string Interface					{ get; set;}
		public string Version					{ get; set;}
		public string SchemaNames				{ get; set;}
		public string SpecID					{ get; set;}
		public string CSPID					{ get; set;}
		public string XPath					{ get; set;}
		public string ContainerParent				{ get; set;}
		public string SecuritizationPlatformCommonTerm		{ get; set;}
		public string DataPointName				{ get; set;}
		public string DataElementDefinition			{ get; set;}
		public string Conditionality				{ get; set;}
		public string ConditionalityDetails			{ get; set;}
		public string LoanStateType				{ get; set;}
		public string LoanRoleType				{ get; set;}
		public string PartyRoleType				{ get; set;}
		public string InMISMO					{ get; set;}
		public string DataFormat				{ get; set;}
		public string ImplementedXMLType			{ get; set;}
		public string CSPSupportedEnumerations			{ get; set;}
		public string ImplementationNotes			{ get; set;}

	}

}
