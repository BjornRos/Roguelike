using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tags
{
    public class TagRuleNormal : ITagRule
    {
        private Vocabulary Vocab = null;
        private string Tag;
        
        public TagRuleNormal(Vocabulary vocab, string tag)
        {
            if (vocab == null) throw new Exception("Trying to add tagrule to noneexisting Vocabulary. Have you used Vocabulary.CreateInstance()?");
            Vocab = vocab;
            if (!vocab.AvailableTags.Contains(tag)) throw new Exception("Necessary tag not in use by map.");
            Tag = tag;

        }

        public void EvaluateAddition(string tag, List<string> tags)
        {   if (Tag==tag)       
                if (Vocab.AvailableTags.Contains(tag))
                    if (!tags.Contains(tag)) tags.Add(tag);

        }

        public void EvaluateRemoval(string tag, List<string> tags)
        {
            if (Tag == tag)
                if (Vocab.AvailableTags.Contains(tag))
                    if (tags.Contains(tag)) tags.Remove(tag);

        }
    }
}
