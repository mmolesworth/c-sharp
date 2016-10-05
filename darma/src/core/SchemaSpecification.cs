using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Css.Csp.DataAcceptance.Darma.Model
{

	public class SchemaSpecification:ICollection
	{
	//Members
		public string CollectionName;
    		private ArrayList empArray = new ArrayList(); 

	//Properties
    		public Employee this[int index]
		{
        		get{return (Employee) empArray[index];}
    		}

    		public int Count
		{
        		get{return empArray.Count;}
    		}
	
    		public object SyncRoot
		{
        		get{return this;}
    		}

    		public bool IsSynchronized
		{
        		get{return false;}
    		}
	
	//Methods
    		public IEnumerator GetEnumerator()
		{
        		return empArray.GetEnumerator();
    		}

    		public void Add(Employee newEmployee)
		{
        		empArray.Add(newEmployee);
    		}

    		public void CopyTo(Array a, int index)
		{
        		empArray.CopyTo(a, index);
    		}
	}
}