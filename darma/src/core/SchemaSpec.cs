using System;
using System.Text;
using System.Collections.Generic;

namespace Com.Css.Csp.DataAcceptance.Darma.Model
{

	public class InterfaceAttribute
		{
			Interface 				{ get; }
			Version 				{ get; }
			schemaNames				{ get; }
			SpecID					{ get; }
			CSPID					{ get; }
			XPath					{ get; }		
			ContainerParent				{ get; }
			SecuritizationPlatformCommonTerm	{ get; }
			DataPointName				{ get; }
			DataElementDefinition			{ get; }
			Conditionality				{ get; }
			ConditionalityDetails			{ get; }
			LoanStateType				{ get; }
			LoanRoleType				{ get; }
			PartyRoleType				{ get; }
			InMISMO					{ get; }
			DataFormat				{ get; }
			ImplementedXMLType			{ get; }
			CSPSupportedEnumerations		{ get; }
			ImplementationNotes			{ get; }
		}
}