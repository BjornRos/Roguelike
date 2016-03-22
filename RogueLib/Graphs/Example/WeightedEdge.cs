using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLib.Graphs
{
    public class WeightedEdge : Edge
    {

        public int Value { get; set; }


        public WeightedEdge(int value, Node node1, Node node2) : base(node1, node2)
        {
            Value = value;
        }
    }
}
