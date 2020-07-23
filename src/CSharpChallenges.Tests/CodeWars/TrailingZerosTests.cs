using CSharpChallenges.CodeWars;
using Xunit;

namespace CSharpChallenges.Test
{
    public class TrailingZerosTests
    {
        [Theory]
        [InlineData(5, 1)]
        [InlineData(25, 6)]
        [InlineData(531, 131)]
        public void ShouldReturnTheNumberOfTrailingZerosInValuesFactorial(int value, int expected)
        {
            Assert.Equal(expected, TrailingZeros.CountTrailingZerosInFactorial(value));
        }
    }
}