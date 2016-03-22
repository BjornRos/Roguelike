using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueLib;
using Tags;

namespace Roguelike
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Vocabulary v = Vocabulary.CreateInstance("Test");
            v.Add("Alfa");
            v.Add("Beta");
            v.Add("Theta");
            v.Add(new TagRuleNormal(v, "Theta"));
            v.Add(new TagRuleOpposite(v, "Alfa", "Beta"));
            

            TestTag tt = new TestTag();
            tt.AddTag("Alfa");
            tt.AddTag("Beta");
            tt.AddTag("Alfa");
            tt.AddTag("Theta");
            */
            Map Karta = MapCreator.GetInstance(new  MapStratDevelopment());
            
        }
    }
    /*
    [TagType("Test")]
    public class TestTag : Taggable
    {
        public TestTag()
        {
            
        }
        // Lista ut varför inte metoderna i Taggable dyker upp på TestTag!!
    }
     * */
}
