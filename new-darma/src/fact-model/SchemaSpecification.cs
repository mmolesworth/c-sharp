using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Css.Csp.DataAcceptance.Darma.FactModel
{
	public class SchemaSpecification
	{
		List<SchemaAttribute> list = new List<SchemaAttribute>();

	//Methods

			
	//Properties
		
		public string FileName { get; set; }
		
		public List<SchemaAttribute> Attributes
		{
			get { return list; }

			set { list = value;}
		}

	} //end class


} //end namespace