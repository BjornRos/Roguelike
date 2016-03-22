using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tags
{
    public class Vocabulary
    {
        private static Dictionary<string, Vocabulary> VocabDict = new Dictionary<string, Vocabulary>();
        public List<string> AvailableTags = new List<string>();
        public List<ITagRule> TagRules = new List<ITagRule>();

        public void Add(ITagRule TagRule)
        {
            //todo: .Contains verkar gå på ref och två likadana regler triggar inte dublettkollen i Vocabulary.Add(TagRule)
            if (TagRules.Contains(TagRule)) throw new Exception("Trying to add tagrule ´" + TagRule + "' to Vocabulary in which it already exist.");
            TagRules.Add(TagRule);
        }

        public void Remove(ITagRule TagRule)
        {
            //todo: .Contains verkar gå på ref och två likadana regler triggar inte dublettkollen i Vocabulary.Remove(TagRule).
            if (!TagRules.Contains(TagRule)) throw new Exception("Trying to remove tagrule ´" + TagRule + "' from Vocabulary in which it is not present.");
            TagRules.Remove(TagRule);
        }

        public void Add (string Tag)
        {
            if (AvailableTags.Contains(Tag)) throw new Exception("Trying to add tag ´" + Tag + "' to Vocabulary in which it already exist.");
            AvailableTags.Add(Tag);
        }

        public void Remove (string Tag)
        {
            if (!AvailableTags.Contains(Tag)) throw new Exception("Trying to remove tag ´" + Tag + "' from Vocabulary in which it is not present.");
            AvailableTags.Remove(Tag);
        }

        public static Vocabulary CreateInstance(string InstanceName)
        {
            Vocabulary v = new Vocabulary();
            VocabDict.Add(InstanceName, v);
            return v;
        }

        public static Vocabulary GetInstance(string InstanceName)
        {
            return VocabDict[InstanceName];
        }
    }
}
