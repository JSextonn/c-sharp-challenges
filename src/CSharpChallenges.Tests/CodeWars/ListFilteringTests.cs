using System.Collections.Generic;
using CSharpChallenges.CodeWars;
using Xunit;

namespace CSharpChallenges.Test
{
    public class ListFilteringTests
    {
        [Theory]
        [InlineData(new object[] { 1, 2, "a", "b" }, new int[] { 1, 2 })]
        public void ShouldReturnListOfNumbersWithoutStrings(IEnumerable<object> values, IEnumerable<int> expected)
        {
            Assert.Equal(expected, ListFiltering.GetIntegersFromList(values));
        }
    }
}