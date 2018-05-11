using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BracketMatcher
{
    public class BracketMatcher
    {
        IEnumerable<string> _brackets = new List<string> { "{}", "[]", "()" };
        IEnumerable<char> _openBrackets = new List<char> { '{', '[', '(' };
        IEnumerable<char> _closeBrackets = new List<char> { '}', ']', ')' };

        public int Match(string str)
        {
            var bracketStack = new Stack();
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            bracketStack = GetMissMatchBracket(str);

            if (_brackets.Any(a => a.Equals(str)))
            {
                return 0;
            }

            if (bracketStack.Count == 0)
            {
                return 0;
            }
            if (bracketStack.Count > 0)
            {
                var missMatchBracket = (Bracket)bracketStack.Peek();
                return missMatchBracket.IndexInString;
            }
            return -1;
        }

        private Stack GetMissMatchBracket(string str)
        {
            var output = new Stack();
            for (var i = 0; i <= str.ToCharArray().Length - 1; i++)
            {
                var s = str.ToCharArray()[i];
                var bracket = new Bracket(s, i);
                if (IsOpenBracket(s))
                {
                    output.Push(bracket);
                }
                if (IsCloseBracket(s))
                {
                    if (output.Count == 0)
                    {
                        output.Push(bracket);
                        continue;
                    }
                    var openBracketInStack = (Bracket)output.Peek();
                    if (IsBracketMatch(openBracketInStack.Character, s))
                    {
                        output.Pop();
                    }
                }
            }
            return output;
        }

        private bool IsOpenBracket(char bracket)
        {
            return _openBrackets.Any(a => a.Equals(bracket));
        }

        private bool IsCloseBracket(char bracket)
        {
            return _closeBrackets.Any(a => a.Equals(bracket));
        }

        private bool IsBracketMatch(char openBracket, char closeBracket)
        {
            var bracketsCharArray = new char[] { openBracket, closeBracket };
            var bracketsString = new string(bracketsCharArray);
            var test = "()".Equals(bracketsString);
            return _brackets.Any(a => a.Equals(bracketsString));
        }
    }
}
