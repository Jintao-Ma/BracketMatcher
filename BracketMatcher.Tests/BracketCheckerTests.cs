
using System;
using Xunit;

namespace BracketMatcher.Tests
{
    public class BracketCheckerTests
    {

        [Theory]
        [InlineData("(", true)]
        [InlineData(")", false)]
        public void IsOpenRoundBracket_RoundBracketCharacter_ReturnTrueOrFalseBasedOnIfTheBracketIsOpenBracket(string bracketCharacter, bool exceptResult)
        {
            //Given
            var roundBracket = new Bracket("(", ")");
            var IBracketChecker = new BracketChecker(roundBracket);

            //When
            var result = IBracketChecker.IsOpenBracket(bracketCharacter);

            //Then
            Assert.Equal(exceptResult, result);
        }

        [Theory]
        [InlineData("(", ")", true)]
        [InlineData("(", "]", false)]
        public void IsMatchRoundBracket_AOpenAndACloseBracket_ReturnTruOrFlaseBasedOnIfTheyMatch(string openBracketCharacter, string closeBracketCharacter, bool exceptResult)
        {
            var roundBracket = new Bracket("(", ")");
            var IBracketChecker = new BracketChecker(roundBracket);

            var result = IBracketChecker.IsBracketMatch(openBracketCharacter, closeBracketCharacter);

            Assert.Equal(exceptResult, result);
        }
    }
}