using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLib
{ // Represents the physical aspect of the map. not the conceptual, which is handled in MapCreationStrategy
    public class Map
    {
        public int sizeX, sizeY;

        public Cell[,] Cell;
        public Map(int X, int Y) 
        {
            sizeX = X;
            sizeY = Y;
            Cell = new Cell[sizeX, sizeY];
        }
    }
}
