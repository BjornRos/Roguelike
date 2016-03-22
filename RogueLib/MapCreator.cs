using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLib
{
    public static class MapCreator
    {
        public static Map GetInstance(MapStrategy strategy)
        {
            var Result = strategy.Build();//.ToMaplet().ToMap();
            return null;
        }
        
    }
}
