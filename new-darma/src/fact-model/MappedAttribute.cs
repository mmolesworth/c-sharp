using System;
using System.Text;

namespace Com.Css.Csp.DataAcceptance.Darma.FactModel
{
	public class MappedAttribute : ISchemaAttribute
	{
	//Members
		SchemaAttribute att;
	
	//Constructors

		public MappedAttribute(SchemaAttribute attribute)
		{
			att = attribute;
		}
	

	//Properties
		public  string	Payload			{ get; set;}
		public  string	ParentContainer		{ get; set;}
		public  string	CDMAttribute		{ get; set;}

	//Implemented Properties
		
		public  string	Interface				
		{ 
			get {return att.Interface;} 
			set {att.Interface = value;}
		}

		public  string	Version
		{ 
			get {return att.Version;} 
			set {att.Version = value;}
		}

		public  string	SchemaNames
		{ 
			get {return att.SchemaNames;} 
			set {att.SchemaNames = value;}
		}

		public  string	SpecID
		{ 
			get {return att.SpecID;} 
			set {att.SpecID = value;}
		}

		public  string	CSPID
		{ 
			get {return att.CSPID;} 
			set {att.CSPID = value;}
		}

		public  string	XPath
		{ 
			get {return att.XPath;} 
			set {att.XPath = value;}
		}

		public  string	ContainerParent
		{ 
			get {return att.ContainerParent;} 
			set {att.ContainerParent = value;}
		}

		public  string	SecuritizationPlatformCommonTerm
		{ 
			get {return att.SecuritizationPlatformCommonTerm;} 
			set {att.SecuritizationPlatformCommonTerm = value;}
		}

		public  string	DataPointName
		{ 
			get {return att.DataPointName;} 
			set {att.DataPointName = value;}
		}

		public  string	DataElementDefinition
		{ 
			get {return att.DataElementDefinition;} 
			set {att.DataElementDefinition = value;}
		}

		public  string	Conditionality
		{ 
			get {return att.Conditionality;} 
			set {att.Conditionality = value;}
		}

		public  string	ConditionalityDetails
		{ 
			get {return att.ConditionalityDetails;} 
			set {att.ConditionalityDetails = value;}
		}

		public  string	LoanStateType
		{ 
			get {return att.LoanStateType;} 
			set {att.LoanStateType = value;}
		}

		public  string	LoanRoleType
		{ 
			get {return att.LoanRoleType;} 
			set {att.LoanRoleType = value;}
		}

		public  string	PartyRoleType
		{ 
			get {return att.PartyRoleType;} 
			set {att.PartyRoleType = value;}
		}

		public  string	InMISMO
		{ 
			get {return att.InMISMO;} 
			set {att.InMISMO = value;}
		}

		public  string	DataFormat
		{ 
			get {return att.DataFormat;} 
			set {att.DataFormat = value;}
		}

		public  string	ImplementedXMLType
		{ 
			get {return att.ImplementedXMLType;} 
			set {att.ImplementedXMLType = value;}
		}

		public  string	CSPSupportedEnumerations
		{ 
			get {return att.CSPSupportedEnumerations;} 
			set {att.CSPSupportedEnumerations = value;}
		}

		public  string	ImplementationNotes
		{ 
			get {return att.ImplementationNotes;} 
			set {att.ImplementationNotes = value;}
		}

	} //end class

} //end namespace
