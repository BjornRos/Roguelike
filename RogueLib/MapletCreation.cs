using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueLib.Graphs;
namespace RogueLib
{
    public class MapletCreation
    {
        public Node Node {get;set;}
        public MapStrategy MapStrategy { get; set; }

        public virtual MapletCreation Build()
        {
            throw new NotImplementedException();
        }
        public virtual Maplet ToMaplet()
        {
            throw new NotImplementedException();
        }
    }
}
