using System;
using System.IO;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Text;


public interface IRule
{

	string 		TempID			{ get; set;}	
	string 		RuleID			{ get; set;}
	string 		RuleDescription 	{ get; set;}
	string 		CriticalMessage 	{ get; set;}

	string		GetSignature();
	string		GetParentSignature();

}

public class DecisionRule : IRule
{
	public		string 		TempID			{ get; set;}	
	public 		string 		RuleID			{ get; set;}
	public		string 		RuleDescription 	{ get; set;}
	public		string 		CriticalMessage 	{ get; set;}
	public		List<Interface> InterfaceCollection 	{ get; set;}
	
	public 	string	GetSignature()
	{
		return "This is my signature";

	}

	public 	string	GetParentSignature()
	{
		return "This is my parent's signature";

	}

}

public class SchemaRule : IRule
{
	public		string 		TempID			{ get; set;}	
	public 		string 		RuleID			{ get; set;}
	public		string 		RuleDescription 	{ get; set;}
	public		string 		CriticalMessage 	{ get; set;}

	public 	string	GetSignature()
	{
		return "This is my signature";

	}

	public 	string	GetParentSignature()
	{
		return "This is my parent's signature";

	}

}


