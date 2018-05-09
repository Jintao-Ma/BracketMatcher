namespace BracketMatcher
{
    public class Bracket
    {
        private string _openBracketCharacter;
        private string _closeBracketCharacter;

        public Bracket(string openBracketCharacter, string closeBracketCharacter)
        {
            this._openBracketCharacter = openBracketCharacter;
            this._closeBracketCharacter = closeBracketCharacter;
        }

        public string OpenBracketCharacter { get => _openBracketCharacter; set => _openBracketCharacter = value; }

        public string CloseBracketCharacter { get => _closeBracketCharacter; set => _closeBracketCharacter = value; }
    }
}