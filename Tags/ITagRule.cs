using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tags
{
    public interface ITagRule
    {
        // returns true if successfully evaluated, regardless of activation.
        void EvaluateAddition (string tag, List<string> tags);
        void EvaluateRemoval (string tag, List<string> tags);
    }
}
