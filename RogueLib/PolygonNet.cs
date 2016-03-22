using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueLib
{
    public class PolygonNet
    {
        public List<PolygonNetPolygon> Polygons
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public System.Collections.Generic.List<PolygonNetPoint> Points
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Moves every point connected, and therefor the entire net, a specific offset. For use mainly when the world grows.
        /// </summary>
        /// <param name="X">Amount to move in X-direction</param>
        /// <param name="Y">Amount to move in Y-direction</param>
        public void Move(float X, float Y)
        {
            throw new System.NotImplementedException();
        }

        public void Query()
        {
            throw new System.NotImplementedException();
        }
    }
}
