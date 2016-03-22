using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueLib.Graphs;

namespace RogueLib
{
    public class MapConstraintNextTo : ISpatialRelation
    {
        public Node Node { get; set; }
        public List<Node> Nodes {get;set;}
        public int Importance {get;set;}

        public MapConstraintNextTo(MapletCreation icm, Node n1, Node n2) 
        {
            Nodes = new List<Node>(2);
            Nodes.Add(n1);
            Nodes.Add(n2);
            Importance = 10;
        }

        public float Evaluate(MapletCreation icm)
        {


            return 0f;
        }

        public MapletCreation Process(MapletCreation icm)
        {
            return null;
        }

    }
}
