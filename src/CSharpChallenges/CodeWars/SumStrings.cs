using System.Numerics;

namespace CSharpChallenges.CodeWars
{
    public static class SumStrings
    {
        public static string Sum(string stringOne, string stringTwo)
            => (BigInteger.Parse(string.IsNullOrEmpty(stringOne) ? "0" : stringOne) +
                BigInteger.Parse(string.IsNullOrEmpty(stringTwo) ? "0" : stringTwo))
                .ToString();
    }
}