namespace BracketMatcher
{
    public class ContentManager : IContentManager
    {
        public ContentManager() { }
        public string TrimContentBeforeIndex(string content, int index)
        {
            return content.Substring(index + 1);
        }
    }
}
