using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueLib
{
    public class PolygonNetPolygon
    {
        /// <summary>
        /// This is a subset of the owning PolygonNet's list of points. It contains the points making up the polygon in drawing order.
        /// </summary>
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
        /// The lines making up the polygon
        /// </summary>
        public List<PolygonNetLine> Lines
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
