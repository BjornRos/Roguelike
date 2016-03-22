using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLib.Graphs
{
    /// <summary>
    /// This class is used to position nodes within a graph.
    /// The Length is the distance between the nodes "at rest", The MaxLength is the maximum the Nodes can be
    /// dragged away from eachother and the MinLength is the closest they can come (midpoint to midpoint).
    /// </summary>
    public class Spring
    {
        public Position PosOne;
        public Position PosTwo;
        public float Length;
        public float MaxLength;
        public float MinLength;
    }
}
