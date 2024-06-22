namespace LeetCodeWithJoe.Problems;

internal class _01_TwoSums
{
    public static int[] TwoSum(int[] nums, int target)
    {
        List<int> result = new List<int>();
        for(int i =0; i< nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if(i==j)
                {
                    continue;
                }
                else if (nums[i] + nums[j] ==target) 
                {
                    result.Add(i);
                    result.Add(j);
                    break;
                }
            }
            if(result.Count > 0)
            {
                break;
            }

        }
        return result.ToArray();
    }
}