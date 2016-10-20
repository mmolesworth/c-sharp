using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.FactModel
{
	public class Glossary
	{
		
		List<CSSInterface> interfaceList = new List<CSSInterface>();
		List<Fact> facts = new List<Fact>();

	//Methods

			
	//Properties
		public string Version {get; set;}
		
		public List<CSSInterface> Interfaces
		{
			get { return interfaceList; }

			set { interfaceList = value;}
		}

		public List<Fact> Facts
		{
			get { return facts; }

			set { facts = value;}
		}

	} //end class


} //end namespace