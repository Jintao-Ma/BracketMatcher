namespace BracketMatcher
{
    public class BracketChecker : IBracketChecker
    {
        private Bracket _bracket;

        public Bracket Bracket { get => _bracket; set => _bracket = value; }
        public BracketChecker(Bracket bracket)
        {
            this._bracket = bracket;
        }

        public bool IsBracketMatch(string openBracketCharacter, string closeBracketCharacter)
        {
            return openBracketCharacter.Equals(_bracket.OpenBracketCharacter) && closeBracketCharacter.Equals(_bracket.CloseBracketCharacter);
        }

        public bool IsCloseBracket(string bracketCharacter)
        {
            return bracketCharacter.Equals(_bracket.CloseBracketCharacter);
        }

        public bool IsOpenBracket(string bracketCharacter)
        {
            return bracketCharacter.Equals(_bracket.OpenBracketCharacter);
        }
    }
}