using System.Collections;
using System.Collections.Generic;

namespace RogueLib.Graphs {

    /// <summary>
    /// Represents a node in a graph. May itself contain a graph for further detail.
    /// 
    /// Responsible upwards for keeping knowledge of size and position of it's total content.
    /// Responsible to neighbors for passing on connecting edges to it´s content
    /// Responsible downwards for providing constraints for for fitting the content.
    /// 
    /// For example, imagine a tower. All rooms must fit in a circular shape, and they should fill it out.
    /// What should happen is that the node which represents the whole floor creates the rooms to be and their
    /// internal topology. The Rooms-to-be are of a subclass designed to fit themselves to the environment specific
    /// to the node. In this case, it would be aware it is fitted around a center and the shape would be first made
    /// rectangular like a regular room and then a filter would be applied to change its shape. It would then be
    /// rotated depending on angle around center.
    /// </summary>

	public class Node {
		public MapStrategy MapStrategy{ get;set;}       // Set in MapStrategy.NodeInit()
        public MapletCreation MapCreation { get; set; } // Set in MapStrategy.NodeInit()
        public string Name { get; set; }
        public List<Edge> Edges { get; set; }
        public List<Node> Nodes { get; set; }
        public int CalculatedValue { get; set; }
        public Position Position { get; set; }


        public Node()
        {
            Edges = new List<Edge>();
            Nodes = new List<Node>();
            
        }

        public Node Build()
        {
            MapCreation.Build();
            return this;
        } 

		public override string ToString()
		{
			return Name + "(" + CalculatedValue + ")";
		}
	}
}