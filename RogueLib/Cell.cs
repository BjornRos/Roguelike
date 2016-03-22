using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tags;


namespace RogueLib
{   
    [TagType("Cell")]
    public class Cell
    {
        private List<string> Tags;



        public Cell DeepCopy()
        {
            Cell c = new Cell();
            c.Tags = Tags.ConvertAll(s => new String(s.ToCharArray()));

            return c;
        }
    }
}
