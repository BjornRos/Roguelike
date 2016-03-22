using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tags
{
    public class TagRuleOpposite : ITagRule
    {
        private string tagOne, tagTwo;
        private Vocabulary Vocab = null;

        public TagRuleOpposite(Vocabulary vocab, string tag1, string tag2)
        {
            if (vocab == null) throw new Exception("Trying to add tagrule to noneexisting Vocabulary. Have you used Vocabulary.CreateInstance()?");
            Vocab = vocab;
            if (!vocab.AvailableTags.Contains(tag1)) throw new Exception("Necessary tag not in use by map.");
            if (!vocab.AvailableTags.Contains(tag2)) throw new Exception("Necessary tag not in use by map.");
            tagOne = tag1;
            tagTwo = tag2;
            
        }

        public void EvaluateAddition(string tag, List<string> tags)
        {
            if ((tag == tagOne) || (tag == tagTwo))
                if (Vocab.AvailableTags.Contains(tag))
                { 
                    string otherTag = (tagOne == tag) ? tagTwo : tagOne;
                    if (tags.Contains(otherTag)) tags.Remove(otherTag);
                    if (!tags.Contains(tag)) tags.Add(tag);
                }
        }

        public void EvaluateRemoval(string tag, List<string> tags)
        {
            if ((tag == tagOne) || (tag == tagTwo))
                if (Vocab.AvailableTags.Contains(tag))
                {
                    string otherTag = (tagOne == tag) ? tagTwo : tagOne;
                    if (tags.Contains(tag)) tags.Remove(tag);
                    if (!tags.Contains(otherTag)) tags.Add(otherTag);
                }
        }
    }
}
