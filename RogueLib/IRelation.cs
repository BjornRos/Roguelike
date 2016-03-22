using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueLib.Graphs;

namespace RogueLib
{
    /// <summary>
    /// The interface for constraints for mapcreation in derivatives of MapCreationStrategy.
    /// They are to be attached to the closest common node for all participants, where they are Evaluated,
    /// Processed and then lets MapCreationStrategy bubble up their results on to greater adventures.
    /// </summary>
    interface IRelation
    {
        /// <summary>
        /// The node the constraint is attached to.
        /// </summary>
        Node Node { get; set; }
        /// <summary>
        /// The Nodes affected by the constraint. The primary or start node is the first one in
        /// cases where they are not peers.
        /// </summary>
        List<Node> Nodes { get; set; }
        /// <summary>
        /// Importance contains 0-9 where 0 is a wish and 9 is written on a clay tablet, for prioritizing.
        /// </summary>
        int Importance { get; set; }
        /// <summary>
        /// Evaluates an ICreateMaplet to see if it's constraint is fullfilled.
        /// </summary>
        ///  <param name="icm">The work in progress that will be processed.</param>
        /// <returns>Evaluate returns a float representing how far from possibly being fullfilled it is. 
        /// 0 or negative means the constraint is fullfilled.</returns>
        float Evaluate(MapletCreation icm);

        /// <summary>
        ///  Returns a new ICreateMaplet that is meant to overwrite parts of the one provided, 
        ///  for example add a door to a wall between two rooms. 
        ///  Only does something if Evaluate approves.
        /// </summary>
        /// <param name="icm">The work in progress that will be processed.</param>
        /// <returns></returns>
        MapletCreation Process(MapletCreation icm);


        
        
    }
}
