
using System.Collections;
using System.Collections.Generic;

namespace RogueLib.Graphs {
	public class Example : Graph{



        //private void ExampleStart () {
        //    Node<string> A, B, C, D, E, F, G, H;
        //    Nodes.Add(A = new Node<string> { Name = "A" });
        //    Nodes.Add(B = new Node<string> { Name = "B" });
        //    Nodes.Add(C = new Node<string> { Name = "C" });
        //    Nodes.Add(D = new Node<string> { Name = "D" });
        //    Nodes.Add(E = new Node<string> { Name = "E" });
        //    Nodes.Add(F = new Node<string> { Name = "F" });
        //    Nodes.Add(G = new Node<string> { Name = "G" });
        //    Nodes.Add(H = new Node<string> { Name = "H" });

        //    Edges.Add (new WeightedEdge (5, A, B));
        //    Edges.Add(new WeightedEdge(7, A, C));
        //    Edges.Add(new WeightedEdge(9, B, C));
        //    Edges.Add(new WeightedEdge(5, B, D));
        //    Edges.Add(new WeightedEdge(8, C, F));
        //    Edges.Add(new WeightedEdge(10, C, G));
        //    Edges.Add(new WeightedEdge(5, E, G));
        //    Edges.Add(new WeightedEdge(3, F, H));
        //    Edges.Add(new WeightedEdge(11, G, H));


        //    foreach (Node n in Nodes)
        //                        if (n != A)
        //                                n.CalculatedValue = 9999;
        //    ShortestPath (A, H);

		//}

		public void ShortestPath(Node n1, Node n2)
		{
			Graphs.Stack<Node> s = new Graphs.Stack<Node> ();

			Node n=null;
			s.Push (n1);


			while (s.NotEmpty()) 
			{

				n = s.Pop();

                foreach (WeightedEdge E in n.Edges) 
				{
					Node ConnectedNode = (E.FirstNode == n) ? E.SecondNode : E.FirstNode;
					int newValue = n.CalculatedValue + E.Value;
					if (newValue < ConnectedNode.CalculatedValue) 
					{
							ConnectedNode.CalculatedValue = newValue;
							s.Push (ConnectedNode);
					}
				}
				if (n==n2)
				{
					//Debug.Log (n2.Name + " reached, distance was "+ n2.calculatedValue.ToString());
				}

			}
		}

	}
}