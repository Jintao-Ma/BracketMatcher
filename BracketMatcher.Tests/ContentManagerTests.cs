using System;
using Xunit;

namespace BracketMatcher.Tests
{
    public class ContentManagerTests
    {
        
        [Fact]
        public void TrimContentBeforeIndex_StringHasBracket_ReturnStringAfterTheFirstBracket()
        {
            //Given
            var content = "1(2dfsd{dfsdf)}";
            var firstBracketIndex = 1;
            var IContentManager = new ContentManager();
            var result = "2dfsd{dfsdf)}";

            //When
            var trimedContent = IContentManager.TrimContentBeforeIndex(content, firstBracketIndex);

            //Then
            Assert.True(result == trimedContent);
        }
    }
}