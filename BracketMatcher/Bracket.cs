namespace BracketMatcher
{
    public class Bracket
    {
        private char _character;
        private int _indexInString;

        public Bracket(char character, int indexInString)
        {
            _character = character;
            _indexInString = indexInString;
        }

        public char Character { get => _character; set => _character = value; }
        public int IndexInString { get => _indexInString; set => _indexInString = value; }
    }
}
