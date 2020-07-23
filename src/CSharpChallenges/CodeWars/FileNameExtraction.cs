using System.Text.RegularExpressions;

namespace CSharpChallenges.CodeWars
{
    public static class FileNameExtraction
    {
        private static readonly Regex FileNameRegex = new Regex(@"^\d+_(?<fileName>[\w | -]+\.\w+)\.\w+$");

        public static string ExtractFileName(string dirtyFileName) =>
            FileNameRegex.Match(dirtyFileName).Groups["fileName"].Value;
    }
}