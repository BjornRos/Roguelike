using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueLib.Graphs;
namespace RogueLib
{
    public class MapStrategy
    {

        public Node Node { get; set; }
        
        public MapletCreation MapletToBe { get; set; }

        public MapStrategy()
        {

        }

        public void NodeInit(List<Node> Siblings, Node home)
        {
            Node = home;
            MapletToBe = new MapletCreation();
            MapletToBe.Node = home;
            MapletToBe.MapStrategy = this;
            home.MapCreation = MapletToBe;
            home.MapStrategy = this;
            Siblings.Add(Node);
        }

        public virtual MapStrategy Build()
        {
            throw new NotImplementedException("Classes should provide their own version of Build. (this is thrown from MapStrategy.Base)");
        }

        public virtual Maplet ToMaplet()
        {
            throw new NotImplementedException("Classes should provide their own version of ToMaplet. (this is thrown from MapStrategy.Base)");
        }
    }
}
