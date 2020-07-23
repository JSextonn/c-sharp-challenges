using System.Numerics;

namespace CSharpChallenges.CodeWars
{
    public static class BigNumberAddition
    {
        public static string Add(string a, string b)
            => (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
    }
}