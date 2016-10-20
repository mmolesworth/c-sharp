using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using Microsoft.VisualBasic.FileIO;


namespace Com.Css.Csp.DataAcceptance.Darma.FactModel
{
	public class SchemaImporter
	{

		public static SchemaSpecification Import(string filename, String delimiter, Boolean usingQuotes)
		{

			FileInfo csvFileInfo = new FileInfo(filename);
			TextFieldParser parser = new TextFieldParser(csvFileInfo.FullName);

			SchemaSpecification spec = new SchemaSpecification();
			spec.FileName = csvFileInfo.Name;

			parser.HasFieldsEnclosedInQuotes = usingQuotes;
			parser.SetDelimiters(delimiter);

			string[] fields;
			
			while (!parser.EndOfData)
			{
				SchemaAttribute sa = new SchemaAttribute();

				fields = parser.ReadFields();

				sa.Interface				= fields[0];
				sa.Version				= fields[1];
				sa.SchemaNames				= fields[2];
				sa.SpecID				= fields[3];
				sa.CSPID				= fields[4];
				sa.XPath				= fields[5];
				sa.ContainerParent			= fields[6];
				sa.SecuritizationPlatformCommonTerm	= fields[7];
				sa.DataPointName			= fields[8];
				sa.DataElementDefinition		= fields[9];
				sa.Conditionality			= fields[10];		
				sa.ConditionalityDetails		= fields[11];
				sa.LoanStateType			= fields[12];
				sa.LoanRoleType				= fields[13];
				sa.PartyRoleType			= fields[14];
				sa.InMISMO				= fields[15];
				sa.DataFormat				= fields[16];
				sa.ImplementedXMLType			= fields[17];
				sa.CSPSupportedEnumerations		= fields[18];
				sa.ImplementationNotes			= fields[19];
				
				spec.Attributes.Add(sa);

			}	 

			parser.Close();

			return spec;	
		}

	} //end class

} //end namespace