using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueLib.Graphs;

namespace RogueLib
{
    public class CreateMapletAreaRoomsAndCorridors : MapletCreation
    {

        
        public CreateMapletAreaRoomsAndCorridors() : base()
        {
        }

        public override MapletCreation Build()
        {
            List<Maplet> maplets = new List<Maplet>();
            foreach (Node n in Node.Nodes)
            {
                //maplets.Add(n.Content.Build());
            }
            

            // TODO: Build ICreateMaplet needs to return more meta data for stiching to function, or maplets need to include this data, but would be ugly i suppose. 
            //return Maplet.Stich(maplets);
            return null; 
        }
        public override  Maplet ToMaplet()
        {
            return null;
        }
    }
}
