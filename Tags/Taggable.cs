using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tags
{

   
    public class Taggable
    {
        private Vocabulary Vocab;
        private List<string> Tags = new List<string>();

        public Taggable()
        {
            string vocabIndex=string.Empty;
            System.Reflection.MemberInfo info = this.GetType();
            object[] attributes = info.GetCustomAttributes(true);
            
            IList<System.Reflection.CustomAttributeData> Cads = info.GetCustomAttributesData();
            foreach (System.Reflection.CustomAttributeData cad in Cads)
            {
                if (cad.AttributeType == typeof(TagTypeAttribute))
                { 
                    vocabIndex = cad.ConstructorArguments[0].Value as string;
                }
            }
            
             
            Vocab = Vocabulary.GetInstance(vocabIndex);
        }

        public void AddTag(string tag)
        {
            foreach (ITagRule rule in Vocab.TagRules) rule.EvaluateAddition(tag, Tags);
        }

        public void RemoveTag(string tag)
        {
            foreach (ITagRule rule in Vocab.TagRules) rule.EvaluateRemoval(tag, Tags);
        }


    }
}
