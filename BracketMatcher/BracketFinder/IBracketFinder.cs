using System.Collections.Generic;

namespace BracketMatcher
{
    interface IBracketFinder
    {
        int GetBracketIndex(string content, string bracketCharacter);
        bool HasBracket(string content, string bracket);
    }
}