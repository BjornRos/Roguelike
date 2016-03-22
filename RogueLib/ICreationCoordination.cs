using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueLib
{
    public interface ICreationCoordination
    {
        /// <summary>
        /// Finds the node to apply this Coordination to. A Coordination is a request for the creation of an actor or object or room or anything really.
        /// </summary>
        /// <param name="NodeFinder">Nodefinder algorithm</param>
        /// <param name="NodeFinderArgs">Arguments for the Nodefinder.</param>
        RogueLib.Graphs.Node FindNode(INodeFinder NodeFinder, INodeFinderArgs NodeFinderArgs);

        /// <summary>
        /// Applies the Coordination Request to the found node.
        /// </summary>
        void ApplyRequest();
    }
}
