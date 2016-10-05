using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

// The XmlRootAttribute allows you to set an alternate name 
// (PurchaseOrder) for the XML element and its namespace. By 
// default, the XmlSerializer uses the class name. The attribute 
// also allows you to set the XML namespace for the element. Lastly,
// the attribute sets the IsNullable property, which specifies whether 
// the xsi:null attribute appears if the class instance is set to 
// a null reference.


namespace Com.Css.Csp.DataAcceptance.Darma.Model {

	[XmlRootAttribute("Glossary", Namespace="http://www.css.com", IsNullable = false)]
	public class Glossary:ICollection
	{
		public string CollectionName;
	
		private ArrayList factArray = new ArrayList(); 

    		public FactType this[int index]
		{
        		get{return (FactType) factArray[index];}
    		}

    		public void CopyTo(Array a, int index)
		{
        		factArray.CopyTo(a, index);
    		}
    
		public int Count
		{
        		get{return factArray.Count;}
    		}

    		public object SyncRoot
		{
        		get{return this;}
    		}
    
		public bool IsSynchronized
		{
        		get{return false;}
    		}
    
		public IEnumerator GetEnumerator()
		{
        		return factArray.GetEnumerator();
    		}

    		public void Add(FactType newFactType)
		{
        		factArray.Add(newFactType);
    		}
	}
}