using System;
using System.Collections.Generic;
using System.Linq;

namespace BracketMatcher
{
    public class BracketMatcher
    {
        IEnumerable<string> brackets = new List<string> { "{}", "[]", "()" };
        IEnumerable<string> openBrackets = new List<string> { "{", "[", "(" };
        IEnumerable<string> closeBrackets = new List<string> { "}", "]", ")" };

        public int Match(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            if (brackets.Any(a => a.Equals(str)))
            {
                return 0;
            }

            return -1;
        }
    }
}
