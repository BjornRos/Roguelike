using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Graphs {
	public class Stack {

		private List<Node> Nodes;

		public Stack()
		{
			Nodes = new List<Node> ();
		}

		public void Push (Node n)
		{
			Nodes.Add (n);
		}

		public Node Pop ()
		{
			Node n = Nodes [Nodes.Count - 1];

			Nodes.Remove (n);

			return n;
		}

		public bool NotEmpty()
		{
			return (Nodes.Count > 0);
		}

		public override string ToString()
		{
			string s = string.Empty;
			foreach (Node n in Nodes)
								s += n.ToString () + " ";
			return s;
		}
	}
}