using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpChallenges.CodeWars
{
    public static class FindDivisors
    {
        public static IEnumerable<int> Find(int value)
        {
            var divisors = new List<int>();
            var max = (int)Math.Sqrt(value);
            for (var divisor = 2; divisor <= max; divisor++)
            {
                if (value % divisor != 0)
                {
                    continue;
                }

                divisors.Add(divisor);
                if (divisor != value / divisor)
                {
                    // Don't add the square root twice
                    divisors.Add(value / divisor);
                }
            }

            return divisors.OrderBy(n => n);
        }
    }
}