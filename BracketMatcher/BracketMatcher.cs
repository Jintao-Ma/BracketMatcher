using System;
using System.Collections.Generic;

namespace BracketMatcher
{
    public class BracketMatcher
    {
        List<string> bracketDictionary = new List<string> { "(", ")", "[", "]", "<", ">", "{", "}" };
        private IBracketFinder _bracketFinder;
        private IContentManager _contentManager;

        public BracketMatcher()
        {
            _bracketFinder = new BracketFinder();
            _contentManager = new ContentManager();
        }

        public string Match(string content)
        {
            var result = "match";
            var bracketList = GetBracketList(content);
            bracketList.Sort((x, y) => y.Item1.CompareTo(x.Item1));
            return result;
        }

        private List<Tuple<int, string>> GetBracketList(string content)
        {
            List<Tuple<int, string>> list = new List<Tuple<int, string>>();
            foreach (var bracketCharacter in bracketDictionary)
            {
                var index = _bracketFinder.GetBracketIndex(content, bracketCharacter);
                var bracket = new Tuple<int, string>(index, bracketCharacter);
                list.Add(bracket);
            }
            return list;
        }
    }
}
