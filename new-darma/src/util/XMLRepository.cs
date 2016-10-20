using System;
using System.Collections;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Com.Css.Csp.DataAcceptance.Darma.Util
{
	public class XMLRepository<T>
	{      

	//Methods
		public Object Load(string filename)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(T));

        		//serializer.UnknownNode += new XmlNodeEventHandler(serializer_UnknownNode);
        		//serializer.UnknownAttribute += new XmlAttributeEventHandler(serializer_UnknownAttribute);

        		using(FileStream fs = new FileStream(filename, FileMode.Open))
			{
        			return serializer.Deserialize(fs);
			}

		}

		public void Save(string filename, Object obj)
		{
        		XmlSerializer 	serializer 	= new XmlSerializer(typeof(T));
        		
			using(TextWriter writer = new StreamWriter(filename))
			{
        			serializer.Serialize(writer, obj);
			}

		}

	//Properties

		//public ICollection Collection { get; set;}



	}// end class

} //end namespace