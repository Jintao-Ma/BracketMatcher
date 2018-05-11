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

        [Fact]
        public void WhenBracketMatch_ReturnZero()
        {
            //Given
            var excepted = 0;

            //When
            var actual = sub.Match("()");

            //Then
            Assert.Equal(excepted, actual);
        }
    }
}
