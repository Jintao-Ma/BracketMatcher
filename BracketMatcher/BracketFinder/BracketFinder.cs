using System;
using System.Collections.Generic;

namespace BracketMatcher
{
    public class BracketFinder : IBracketFinder
    {
        public BracketFinder() { }

        public int GetBracketIndex(string content, string openBracket)
        {
            return content.IndexOf(openBracket);
        }

        public bool HasBracket(string content, string bracket)
        {
            return content.IndexOf(bracket) > 0;
        }
    }
}