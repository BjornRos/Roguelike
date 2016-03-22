using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueLib.Graphs;

namespace RogueLib
{
    public class CreateMapletRectRoom : MapletCreation
    {


        public int TargetSize { get; set; }
        public int Size { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }

        public bool Adjust()
        {
            return true;
        }

        public bool Stretch(int X, int Y)
        {
            return true;
        }

        public override MapletCreation Build()
        {
            return this;
        }



        public override Maplet ToMaplet()
        {
            return null;
        }

    }
}
