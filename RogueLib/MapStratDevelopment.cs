using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueLib.Graphs;
using Tags;

namespace RogueLib
{
    public class MapStratDevelopment : MapStrategy
    {
        

        private const int MAPSIZEX = 100;
        private const int MAPSIZEY = 50;
        private const int ROOMS = 10;

        private Map map;
        private Graph graph;

        public MapStratDevelopment() : base()
        {
        }
        
        // This builds a testenvironment while still developing the bones of the framework.
        public override MapStrategy Build()
        {
            Map map = null;
            map = new Map(MAPSIZEX,MAPSIZEY);
            Vocabulary.CreateInstance("Cell");
            Vocabulary.GetInstance("Cell").Add("Transparent");
            Vocabulary.GetInstance("Cell").Add("Opaque");
            Vocabulary.GetInstance("Cell").Add("Walkable");
            Vocabulary.GetInstance("Cell").Add("Impassable");
            Vocabulary.GetInstance("Cell").Add("OpenSpace");
            Vocabulary.GetInstance("Cell").Add("Wall");
            Vocabulary.GetInstance("Cell").Add(new TagRuleOpposite(Vocabulary.GetInstance("Cell"), "Transparent", "Opaque"));
            Vocabulary.GetInstance("Cell").Add(new TagRuleOpposite(Vocabulary.GetInstance("Cell"), "Walkable", "Impassable"));
            Vocabulary.GetInstance("Cell").Add(new TagRuleOpposite(Vocabulary.GetInstance("Cell"), "OpenSpace", "Wall"));

            graph = new MapStratDevGraph();

            
            MapStratAreaRoomsAndCorridors Entrence = new MapStratAreaRoomsAndCorridors();
            Node EntrenceNode = new Node();
            Entrence.NodeInit(graph.Root.Nodes,EntrenceNode);
            
            MapStratAreaRoomsAndCorridors TheLair = new MapStratAreaRoomsAndCorridors();
            Node TheLairNode = new Node();
            TheLair.NodeInit(graph.Root.Nodes, TheLairNode);
          
            graph.Root.Edges.Add( new Edge (EntrenceNode, TheLairNode));

            MapStratRectRoom EntrenceHallway = new MapStratRectRoom();
            Node EntrenceHallwayNode = new Node();
            EntrenceHallway.NodeInit(EntrenceNode.Nodes, EntrenceHallwayNode);
            
            MapStratRectRoom ReceptionRoom = new MapStratRectRoom();
            Node ReceptionRoomNode = new Node();
            ReceptionRoom.NodeInit(EntrenceNode.Nodes, ReceptionRoomNode);
            
            EntrenceNode.Edges.Add(new Edge(EntrenceHallwayNode, ReceptionRoomNode));

            graph.Root.Edges.Add(new Edge(EntrenceHallwayNode, ReceptionRoomNode));

            MapStratRectRoom ActualLairRoom = new MapStratRectRoom();
            Node ActualLairNode = new Node();
            ActualLairRoom.NodeInit(TheLairNode.Nodes, ActualLairNode);

            // todo: go down and turn in the leaves, and have them ask for actual mapspace, calculate parents space.
            // todo: There are atm edges representing portals. Use a spatial relationship.
            // todo: There is an edge between midlevel nodes Entrence and thelair, both should delegate and coordinate this down
            //       Theactuallair should be given a distance from theentrence and a corridor should have to be built, in itself consisting of two long rooms.


            return this;
        }
    }
}
