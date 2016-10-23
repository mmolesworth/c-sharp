using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public class RuleInventory : ICollection
	{
		
	//Members
      		private ArrayList 	collection = new ArrayList(); 

	//Methods
    		public Rule this[int index]
		{
        		get{return (Rule) collection[index];}
    		}
		
    		public void CopyTo(Array a, int index)
		{
        		collection.CopyTo(a, index);
    		}
		
    		public int Count
		{
        		get{return collection.Count;}
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
        		return collection.GetEnumerator();
    		}

    		public void Add(Rule op)
		{
        		collection.Add(op);
    		}

    		public void Remove(Rule op)
		{
        		collection.Remove(op);
    		}

		
	} //end class

} //end namespace