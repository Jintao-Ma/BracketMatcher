namespace BracketMatcher
{
    interface IBracketFinder
    {
        int GetBracketIndex(string content, string openBracket);
        bool HasBracket(string content, string bracket);
    }
}