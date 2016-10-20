using System;
using System.Collections;
using System.Text;

namespace Com.Css.Csp.DataAcceptance.Darma.FactModel
{
	public class InterfaceCollection:ICollection
	{
	
	//Members
      		private ArrayList 	interfaceArray = new ArrayList(); 

	//Methods
    		public CSSInterface this[int index]
		{
        		get{return (CSSInterface) interfaceArray[index];}
    		}
		
    		public void CopyTo(Array a, int index)
		{
        		interfaceArray.CopyTo(a, index);
    		}
		
    		public int Count
		{
        		get{return interfaceArray.Count;}
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
        		return interfaceArray.GetEnumerator();
    		}

    		public void Add(CSSInterface cssInterface)
		{
        		interfaceArray.Add(cssInterface);
    		}

    		public void Remove(CSSInterface cssInterface)
		{
        		interfaceArray.Remove(cssInterface);
    		}

	} //end InterfaceCollection class


} //end namespace