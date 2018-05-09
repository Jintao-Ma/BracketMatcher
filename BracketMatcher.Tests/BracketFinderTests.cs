using System;
using Xunit;

namespace BracketMatcher.Tests
{
    public class BracketFinderTests
    {
        [Fact]
        public void GetBracketIndex_StringHasBracket_ReturnOpenBracKetIndex()
        {
            var content = "1(2{3})";
            var openBracket = "(";
            var IBracketFinder = new BracketFinder();
            var result = 1;

            var braceketIndex = IBracketFinder.GetBracketIndex(content, openBracket);

            Assert.True(braceketIndex == result);
        }


        [Fact]
        public void HasBracket_StringDoesNotHaveBracket_ReturnFalse()
        {
            //Given
            var content = "asdfasdf";
            var bracket = ")";
            var IBracketFinder = new BracketFinder();
            var result = false;

            //When
            var hasBracket = IBracketFinder.HasBracket(content, bracket);

            //Then
            Assert.Equal(result, hasBracket);
        }
    }
}