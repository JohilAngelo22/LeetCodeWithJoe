namespace LeetCodeWithJoe.PatternsProblems.SlidingWindowPattern;

public class _01_Maximum_Strong_Pair_XOR_I
{
    public static int MaximumStrongPairXor(int[] nums)
    {
        var result = 0;

        foreach (var x in nums)
        {
           
            foreach (var y in nums)
            {
                if (x.Equals(y))
                    continue;
                    if (Math.Abs(x - y) <= Math.Min(x, y))// Finding the stron pair with the guven condition |X-Y| <= min(X,Y)
                {
                    result = Math.Max(result, x ^ y);
                }
            }
        }
        return result;
    }
}