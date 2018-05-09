namespace BracketMatcher
{
    interface IBracketChecker
    {
        bool IsOpenBracket(string bracketCharacter);
        bool IsCloseBracket(string bracketCharacter);
        bool IsBracketMatch(string openBracketCharacter, string closeBracketCharacter);
    }
}