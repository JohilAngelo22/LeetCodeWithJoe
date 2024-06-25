using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeWithJoe.Problems
{
    internal class _02_Valid_Parentheses
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new();//(
            List<bool> isFlags = new ();
            Dictionary<char, char> map = new()
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };
            foreach (char str in s)//)
            {
                if (!map.ContainsKey(str))
                {
                    stack.Push(str);//(
                }
                else
                {
                    if(stack.Count == 0 && stack.Count >1) 
                    {
                        return false;
                    }
                    var popelement = stack.Pop();
                    if (map[str]== popelement)
                    {
                        isFlags.Add(true);
                    }
                    else
                    {
                        isFlags.Add(false);
                    }
                }
            }
            return isFlags.All(a => a.Equals(true)) && isFlags.Count > 0 && stack.Count == 0;
        }
    }
}
