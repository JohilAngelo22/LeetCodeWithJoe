namespace LeetCodeWithJoe.PatternsProblems.SlidingWindowPattern;

public class _02_Substrings_of_Size_Three_with_Distinct_Characters
{
    public static int CountGoodSubstrings(string s)
    {
        List<string> list = new List<string>();
        int count = 0;
        for(int i=0; i <= s.Length-3; i++)
        {
            list.Add(s.Substring(i, 3));
        }

        foreach(string lst in list)
        {
            if(lst.ToList().GroupBy(x => x).Count()==3)
            {
                count++;
            }
        }

        return count;
    }
}
