namespace CSharpChallenges.CodeWars
{
    public static class DigitalRoot
    {
        public static int CalculateDigitalRoot(long value)
        {
            var digitSum = value.SumDigits();
            return digitSum >= 10 ? CalculateDigitalRoot(digitSum) : digitSum;
        }
    }
}