using System;
using System.Text;


namespace Com.Css.Csp.DataAcceptance.Darma.Model {

public interface IOperator
{
	string Symbol		{ get; set; }
	string Description	{ get; set; }

}


class StandardOperator
{

	public string Symbol { get; set; }
	
	public string Description { get; set;}

}

}