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
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            return FindFirstMissMatchBracket(str);
        }

        private int FindFirstMissMatchBracket(string str)
        {
            var bracketStack = new Stack();

            bracketStack = CreateMissMatchBracketStack(str);

            if (BracketStackDoesNotHasMatchBrackets(bracketStack, str))
            {
                return 0;
            }

            if (bracketStack.Count > 0)
            {
                return GetFirstMissMatchBracketIndex(bracketStack);
            }
            return -1;
        }

        private Stack CreateMissMatchBracketStack(string str)
        {
            var bracketStack = new Stack();
            for (var i = 0; i <= str.ToCharArray().Length - 1; i++)
            {
                var s = str.ToCharArray()[i];
                var bracket = new Bracket(s, i);
                bracketStack = PushBracketIntoBracketStack(bracketStack, bracket);
            }
            return bracketStack;
        }

        private Stack PushBracketIntoBracketStack(Stack bracketStack, Bracket bracket)
        {
            var output = bracketStack;
            var bracketCharacter = bracket.Character;
            if (IsOpenBracket(bracketCharacter))
            {
                output = PushOpenBracketIntoBracketStack(bracketStack, bracket);
            }
            if (IsCloseBracket(bracketCharacter))
            {
                output = PushCloseBracketIntoBracketStack(bracketStack, bracket);
            }
            return output;
        }

        private bool BracketStackDoesNotHasMatchBrackets(Stack bracketStack, string str)
        {
            return (_brackets.Any(a => a.Equals(str))) || bracketStack.Count == 0;
        }

        private int GetFirstMissMatchBracketIndex(Stack bracketStack)
        {
            var firstMissMatchBracket = (Bracket)bracketStack.Peek();
            return firstMissMatchBracket.IndexInString;
        }

        private Stack PushOpenBracketIntoBracketStack(Stack bracketStack, Bracket openBracket)
        {
            var output = bracketStack;
            output.Push(openBracket);
            return output;
        }

        private Stack PushCloseBracketIntoBracketStack(Stack bracketStack, Bracket closeBracket)
        {
            var output = bracketStack;
            if (HasMatchOpenBracketInStack(bracketStack, closeBracket))
            {
                output.Pop();
            }
            else
            {
                output.Push(closeBracket);
            }
            return output;
        }

        private bool HasMatchOpenBracketInStack(Stack bracketStack, Bracket closeBracket)
        {
            if (bracketStack.Count == 0)
            {
                return false;
            }

            var openBracketInStack = (Bracket)bracketStack.Peek();
            if (IsBracketMatch(openBracketInStack.Character, closeBracket.Character))
            {
                return true;
            }

            return false;
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
