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
        [InlineData("w(wee)213")]
        [InlineData("w(wee)213{}")]
        [InlineData("w(wee)2[]13{}")]
        [InlineData("{}w(w[]ee)2[]13{}")]
        public void WhenBracketMatch_ReturnZero(string str)
        {
            //Given
            var excepted = 0;

            //When
            var actual = sub.Match(str);

            //Then
            Assert.Equal(excepted, actual);
        }

        [Theory]
        [InlineData("(qweqwe", 0)]
        [InlineData("qw(eqwe", 2)]
        [InlineData("qweqw)e", 5)]
        [InlineData("qweqwe)", 6)]
        [InlineData("{qweqwe", 0)]
        [InlineData("qw[eqwe", 2)]
        [InlineData("qweqw}e", 5)]
        [InlineData("qweqwe]", 6)]
        [InlineData("qw(e)qwe]", 8)]
        [InlineData("{}qw(e)qwe]", 10)]
        [InlineData("{qw(e)qwe[]", 0)]
        [InlineData("wq{q[w(e)q]we[]", 2)]
        public void WhenThereIsOneMissMatch_ReturnIndexOfTheMissMatchBracket(string str, int excepted)
        {
            //When
            var actual = sub.Match(str);

            //Then
            Assert.Equal(excepted, actual);
        }

        // [Theory]
        // public void WhenThereAreMoreThanOneMissMatch_ReturnAllIndexOfTheMissMatchBrackets(string str, int[] excepted)
        // {
        //     //Given

        //     //When

        //     //Then
        // }
    }
}
