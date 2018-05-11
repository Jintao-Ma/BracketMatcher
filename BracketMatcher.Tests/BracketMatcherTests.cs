using System;
using Xunit;

namespace BracketMatcher.Tests
{
    public class BracketMatcherTests
    {
        BracketMatcher sub = new BracketMatcher();

        [Fact]
        public void WhenThereisNoBracket_ReturnZero()
        {
            //Given
            var excepted = 0;

            //When
            var actual = sub.Match("");

            //Then
            Assert.Equal(excepted, actual);
        }

        [Theory] 
        [InlineData("{}")]
        [InlineData("[]")]
        [InlineData("()")]
        [InlineData("(qwe)")]
        [InlineData("()wqwee")]
        [InlineData("wqwee()")]
        [InlineData("wwee()213")]
        public void WhenBracketMatch_ReturnZero(string str)
        {
            //Given
            var excepted = 0;

            //When
            var actual = sub.Match(str);

            //Then
            Assert.Equal(excepted, actual);
        }
    }
}
