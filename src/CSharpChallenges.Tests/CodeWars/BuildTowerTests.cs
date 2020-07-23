using CSharpChallenges.CodeWars;
using Xunit;

namespace CSharpChallenges.Test
{
    public class BuildTowerTests
    {
        [Theory]
        [InlineData(0, new string[] { })]
        [InlineData(3, new[]
        {
            "  *  ",
            " *** ",
            "*****",
        })]
        [InlineData(6, new[]
        {
            "     *     ",
            "    ***    ",
            "   *****   ",
            "  *******  ",
            " ********* ",
            "***********"
        })]
        public void ShouldReturnStringToCorrectlyResembleATower(int floors, string[] expected)
        {
            Assert.Equal(expected, BuildTower.Build(floors));
        }
    }
}