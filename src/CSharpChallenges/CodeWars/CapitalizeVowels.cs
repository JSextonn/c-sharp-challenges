using System.Text.RegularExpressions;

namespace CSharpChallenges.CodeWars
{
    public static class CapitalizeVowels
    {
        private static readonly Regex IsVowelRegex = new Regex(@"[aeiou]");

        public static string Capitalize(string s) => IsVowelRegex.Replace(s, (match) => match.Value.ToUpper());
    }
}