using System.Collections;
using System.Collections.Generic;

namespace RogueLib.Graphs {

	public class Edge  {



		public Node FirstNode;
		public Node SecondNode;
          

		public Edge(Node node1, Node node2)
		{

			FirstNode = node1;
			SecondNode = node2;
			node1.Edges.Add (this);
			node2.Edges.Add (this);

		}

	}
}