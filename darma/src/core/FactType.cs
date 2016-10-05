using System;
using System.Text;

namespace Com.Css.Csp.DataAcceptance.Darma.Model
{

	public interface IFactType
	{
		public string GetSignature();

		public string GetIdentifier();

		public string GetExternalDescription();

		public string GetInternalDescription();
		
		public string GetDecisionDescription();

	}


	public class DerivedFact : IFactType
	{
		public string GetSignature()
		{
			return "TODO: Implement signature method";
		}

		public string GetExternalDescription()
		{
			return "TODO: Implement get ULDD method";
		}

		public string GetInternalDescription()
		{
			return "TODO: Implement get CDM method";
		}

		public string GetDecisionDescription()
		{
			return "TODO: Implement get CTM method";
		}
	}

	public class ULDDFact : IFactType
	{

		InterfaceSpecification 	mySpec;
		CDMMapping		myMapping;
		string			ctmDescription;

		
	//constructors
		public ULDDFact();
		
		public ULDDFact(InterfaceSpec spec)
		{
			mySpec = spec;
		}

		public ULDDFact(InterfaceSpec spec, CDMMapping mapping)
		{
			mySpec 		= spec;
			myMapping 	= mapping;
		}

	//IFactType methods
		public string GetSignature()
		{
			return "TODO: Implement signature method";
		}

		public string GetExternalDescription()
		{
			return "TODO: Implement get external description method";
		}

		public string GetInternalDescription()
		{
			return "TODO: Implement get internal description method";
		}

		public string GetDecisionDescription()
		{
			return "TODO: Implement get Decision description method";
		}
	
	//methods
		

	//properties
		public 
	}


	
	public class CDMMapping
	{
		CSPID					{ get; set; }		
		Payload					{ get; set; }
		Parent Container			{ get; set; }
		CDMAttribute				{ get; set; }

	}
} //end namespace