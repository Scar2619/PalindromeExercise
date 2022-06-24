using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class WordSmithTest
    {
        [Theory]
        [InlineData("racecar", true)] // ← you will need to put some test data and expected result here.
        [InlineData("civic", true)]
        [InlineData("hello", false)]
        [InlineData("kayak", true)]
        [InlineData("hola", false)]
        [InlineData("mom", true)]
        [InlineData("data", false)]
        [InlineData("noon", true)]
        public void TestIsAPalindrome(string str, bool expected)
        {
            WordSmith challenger = new WordSmith();

            var actual = challenger.IsAPalindrome(str);

            Assert.Equal(expected, actual);
        }

    }
}
