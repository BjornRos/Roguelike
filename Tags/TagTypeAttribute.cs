using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tags
{
    [AttributeUsage(System.AttributeTargets.Class, Inherited = true)]
    public class TagTypeAttribute : System.Attribute
    {
        private readonly Vocabulary Vocab;

        public TagTypeAttribute(string vocabIndex)
        {
            Vocab = Vocabulary.GetInstance(vocabIndex);
        }
    }
}
