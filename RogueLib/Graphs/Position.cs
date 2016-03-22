using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLib.Graphs
{
    /// <summary>
    /// Meant for use in MapCreationStrategies. Keeps track of a node's position, size and forceattributes.
    /// </summary>
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }

        public int MidX 
        {   
            get 
            { 
                return X + (SizeX / 2);
            }
            set
            {
                X = value - (SizeX / 2);
            }
        }
        public int MidY
        {
            get
            {
                return Y + (SizeY / 2);
            }
            set
            {
                Y = value - (SizeY / 2);
            }
        }

        public int TopBoundery { get { return Y + SizeY; } }
        public int LowBoundery { get { return Y; } }
        public int RightBoundery { get { return X + SizeX; } }
        public int LeftBoundery { get { return X; } }

        public bool WestOf(Position p)
        {
            return (X + SizeX) < p.X;
        }
        public bool EastOf(Position p)
        {
            return X > (p.X + p.SizeX);
        }
        public bool NorthOf(Position p)
        {
            return (Y + SizeY) > p.Y;
        }
        public bool SouthOf(Position p)
        {
            return (Y + SizeY) > p.Y;
        }

        public void MoveWestOf(Position p)
        {
            X = p.X - (SizeX + p.SizeX);
        }
        public void MoveEastOf(Position p)
        {
            X = p.X + (SizeX + p.SizeX);
        }
        public void MoveNorthOf(Position p)
        {
            Y = p.Y + (SizeY + p.SizeY);
        }
        public void MoveSouthOf(Position p)
        {
            Y = p.Y - (SizeY + p.SizeY);
        }

    }
}
