using System;
using System.Linq;
/*
 * @lc app=leetcode id=434 lang=csharp
 *
 * [434] Number of Segments in a String
 */
namespace countSegments
{
    // @lc code=start
    public class Solution
    {
        public int CountSegments(string s)
        {
            s = s.Trim();
            if (s.Length == 0) return 0;
            return s.Split(" ", StringSplitOptions.RemoveEmptyEntries).Count();
        }
    }
    // @lc code=end

}