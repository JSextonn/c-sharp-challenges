using System.Collections.Generic;
using CSharpChallenges.CodeWars;
using Xunit;

namespace CSharpChallenges.Test
{
    public class OnesAndZeroesTests
    {
        [Theory]
        [InlineData(new int[] { 0, 0, 0, 1 }, 1)]
        public void ShouldReturnIntegerGivenArrayOfBits(IEnumerable<int> bits, int expected)
        {
            Assert.Equal(expected, OnesAndZeroes.BinaryToInt32(bits));
        }
    }
}