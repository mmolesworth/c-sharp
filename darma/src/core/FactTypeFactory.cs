using System;
using System.IO;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Text;



interface IFactTypeFactory
{
	
	IFactType createFactType();

}

public class ULDDFactTypeFactory
{
	
	IFactType createFactType()
	{
		return new ULDDFactType();
	}

}

public class DerivedFactTypeFactory
{

	IFactType createFactType()
	{
		return new DerivedFactType();
	}


}
