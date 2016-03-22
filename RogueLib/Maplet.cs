using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLib
{
    // A grid of data, like a map cutout.
    public class Maplet
    {
        public Cell[,] Data;

        // Create a uniform maplet filled with identical cells.
        public Maplet(int sizeX, int sizeY, Cell original)
        {
            Data = new Cell[sizeX,sizeY];
            for (int x = 0; x < sizeX; x++)
                for (int y = 0; y < sizeY; y++)
                {
                    Data[x, y] = original.DeepCopy();
                }
        }

        // Cut out a piece of a map
        public Maplet(Map map, int mapX, int mapY, int sizeX, int sizeY)
        {
            if (mapX + sizeX > map.sizeX) throw new Exception("Cutout area extends beyond the map´s X-axis.");
            if (mapY + sizeY > map.sizeY) throw new Exception("Cutout area extends beyond the map´s Y-axis.");
            if (mapX < 0) throw new Exception("Cutout area starts before the map´s X-axis.");
            if (mapY < 0) throw new Exception("Cutout area starts before the map´s Y-axis.");
            Data = new Cell[sizeX, sizeY];
            for (int x = 0; x < sizeX; x++)
                for (int y = 0; y < sizeY; y++)
                {
                    Data[x, y] = map.Cell[mapX+x,mapY+y].DeepCopy();
                }
        }

        public Map ToMap()
        {
            return null;
        }

    }
}
