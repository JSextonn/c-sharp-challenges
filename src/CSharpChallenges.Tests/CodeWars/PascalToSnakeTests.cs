using CSharpChallenges.CodeWars;
using Xunit;

namespace CSharpChallenges.Test
{
    public class PascalToSnakeTests
    {
        [Theory]
        [InlineData("TestController", "test_controller")]
        [InlineData("MoviesAndBooks", "movies_and_books")]
        public void ShouldReturnTheCorrectlyConvertedStringToSnakeCase(string input, string expected)
        {
            Assert.Equal(expected, PascalToSnake.ToSnakeCase(input));
        }
    }
}