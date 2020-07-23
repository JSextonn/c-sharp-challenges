using System.Collections.Generic;
using System.Linq;

namespace CSharpChallenges.CodeWars
{
    public static class LowestTwo
    {
        public static int SumTwoSmallestNumber(IEnumerable<int> numbers)
            => numbers.OrderBy(number => number).Take(2).Sum();
    }
}