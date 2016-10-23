using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.RuleModel
{
	public class OperatorCollection : ICollection
	{
		
	//Members
      		private ArrayList 	collection = new ArrayList(); 

	//Methods
    		public OperatorExpression this[int index]
		{
        		get{return (OperatorExpression) collection[index];}
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

    		public void Add(OperatorExpression op)
		{
        		collection.Add(op);
    		}

    		public void Remove(OperatorExpression op)
		{
        		collection.Remove(op);
    		}

		
	} //end class

} //end namespace