using System;
using System.Collections.Generic;

namespace CSharpChallenges.CodeWars
{
    public static class OnesAndZeroes
    {
        public static int BinaryToInt32(IEnumerable<int> bits) =>
             Convert.ToInt32(string.Join("", bits), 2);
    }
}