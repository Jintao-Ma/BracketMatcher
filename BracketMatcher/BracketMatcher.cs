using System;
using System.Collections.Generic;

namespace BracketMatcher
{
    public class BracketMatcher
    {
        public BracketMatcher()
        {
        }

        public int Match(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            return -1;
        }
    }
}
