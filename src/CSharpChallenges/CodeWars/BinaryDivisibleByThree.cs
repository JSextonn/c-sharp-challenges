using System.Text.RegularExpressions;

namespace CSharpChallenges.CodeWars
{
    public static class BinaryDivisibleByThree
    {
        private static readonly Regex DivisibleByThreeRegex = new Regex(@"^0*(0*(1(01*0)*10*)0*)*$");

        public static bool IsDivisibleByThree(string binary)
            => !string.IsNullOrEmpty(binary) && DivisibleByThreeRegex.IsMatch(binary);
    }
}