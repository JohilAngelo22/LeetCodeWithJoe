using LeetCodeWithJoe.PatternsProblems.SlidingWindowPattern;
using LeetCodeWithJoe.Problems;

namespace LeetCodeWithJoe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var TwoSum = _01_TwoSums.TwoSum([3, 3], 6);
            var IsValid = _02_Valid_Parentheses.IsValid("[[[]");
            var MaximumStrongPairXor = _01_Maximum_Strong_Pair_XOR_I.MaximumStrongPairXor([1, 2, 3, 4, 5]);
            var CountGoodSubstrings = _02_Substrings_of_Size_Three_with_Distinct_Characters.CountGoodSubstrings("aababcabc");
        }
    }
}
