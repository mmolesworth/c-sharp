using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Com.Css.Csp.DataAcceptance.Darma.Util.Graphing
{
	[XmlRoot(ElementName = "graphml", IsNullable = false)]
	public class GraphML
	{
	//Constructors
		public GraphML()
		{
			this.Graphs = new List<Graph>();

		}
		
	//Properties
		[XmlElement("key")]
		public List<Key> Keys { get; set; }

		[XmlElement("graph")]
		public List<Graph> Graphs { get; set; }
	
	}

	
	public abstract class Component
	{
	//Constructors
		protected Component()
		{

		}

		protected Component(string id)
		{
			this.ID = id;
		}

	//Properties
    		[XmlAttribute("id")]
    		public string ID { get; set; }

	} //end class Component


	public class Graph : Component
	{
	//Constructors
		public Graph() : base()
    		{
        		this.Components = new List<Component>();
    		}

		public Graph(string id):base(id)
		{
			this.Components = new List<Component>();
		}

		public Graph(string id, string edgeDefault):base(id)
		{
			this.Components = new List<Component>();
			this.EdgeDefault = edgeDefault;
		}

	//Methods
		public void SetEdgeDefault(string edgeDefault)
		{
			this.EdgeDefault = edgeDefault;
		}

	//Properties
    		[XmlAttribute("edgedefault")]
    		public string EdgeDefault { get; set; }

		[XmlRoot(Namespace = Constants.Namespace)]
    		[XmlElement("graph", typeof(Graph))]
    		[XmlElement("node", typeof(Node))]
		[XmlElement("edge", typeof(Edge))]
		[XmlElement("hyperedge", typeof(HyperEdge))]
    		public List<Component> Components { get; set; }

	}// end class Graph


	public class Node : Component
	{
	//Constructors
		public Node() : base()
		{

		}

		public Node(string id):base(id)
		{

		}

	//Properties
		[XmlArray("port")]
    		public List<Port> Ports { get; set; }

	}//end class Node


	public class Port
	{
	//Constructors
		public Port()
		{

		}

		public Port(string name)
		{
			this.Name = name;
		}

	//Properties
		[XmlAttribute("name")]
    		public string Name { get; set; }

		[XmlElement("data")]
    		public Data Data { get; set; }

	} //end class Port


	public class Edge : Component
	{
	//Constructors
		public Edge() : base()
		{
			
		}

		public Edge(string id, Node source, Node target) : base(id)
		{
			this.SourceAttribute = source.ID;
			this.TargetAttribute = target.ID;
		}

	//Methods
		public void SetSourceNode(Node source)
		{
			this.SourceAttribute = source.ID;
		}

		public void SetTargetNode(Node target)
		{
			this.TargetAttribute = target.ID;
		}


	//Properties
		[XmlAttribute("source")]
    		public string SourceAttribute { get; set; }  

		[XmlAttribute("target")]
    		public string TargetAttribute { get; set; }

		[XmlAttribute("sourceport")]
    		public string SourcePort { get; set; }

		[XmlAttribute("targetport")]
    		public string TargetPort { get; set; }

		[XmlElement("data")]
    		public Data Data { get; set; }


	} //end class Edge

	public class HyperEdge : Component
	{
	//Constructors
		public HyperEdge() : base()
		{

		}

		public HyperEdge(string id) : base(id)
		{

		}

	//Properties
		[XmlElement("endpoint")]
    		public List<EndPoint> EndPoints { get; set; }

	}


	public class EndPoint
	{
	//Constructors
		public EndPoint()
		{

		}

		public EndPoint(Node node, Port port)
		{
			this.Node = node.ID;
			this.Port = port.Name;
		}


	//Methods
		public void SetNode(Node node)
		{
			this.Node = node.ID;
		}
		
		public void SetPort(Port port)
		{
			this.Port = port.Name;
		}

	//Properties
		[XmlAttribute("node")]
    		public String Node { get; set; }

		[XmlAttribute("port")]
    		public String Port { get; set; }

	} //end class EndPoint


	public class Key
	{
	//Constructors
		public Key()
		{

		}

		public Key(String id, String attributeFor, String attributeName, String attributeType)
		{
			this.ID = id;
			this.AttributeFor = attributeFor;
			this.AttributeName = attributeName;
			this.AttributeType = attributeType;

		}


	//Methods


	//Properties
		[XmlAttribute("id")]
    		public String ID { get; set; }

		[XmlAttribute("for")]
    		public String AttributeFor { get; set; }

		[XmlAttribute("attr.name")]
    		public String AttributeName { get; set; }

		[XmlAttribute("attr.type")]
    		public String AttributeType { get; set; }

	} //end class Key


	public class Data
	{
	//Constructors
		public Data()
		{

		}

		public Data(Key key, String value)
		{
			this.Key = key; 
			this.KeyAttribute = key.ID;
			this.Value = value;

		}


	//Methods	
		public void SetKey(Key key)
		{
			this.Key= key;
			this.KeyAttribute = key.ID;
		}


	//Properties
		[XmlIgnore]
    		public Key Key 			{ get; set; }

		[XmlAttribute("key")]
    		public String KeyAttribute 	{ get; set; }

		[XmlText]
    		public String Value		{ get; set; }


	} //end class Data


} //end namespace Graphing
