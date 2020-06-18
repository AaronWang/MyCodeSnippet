using System;
/*
 * @lc app=leetcode id=633 lang=csharp
 *
 * [633] Sum of Square Numbers
 */
using System.Collections.Generic;

namespace JudgeSquareSum
{
    // @lc code=start
    public class Solution
    {
        public bool JudgeSquareSum(int c)
        {
            //hash set solution
            HashSet<int> hs = new HashSet<int>();
            int sqrt = (int)Math.Sqrt(c);
            if (sqrt * sqrt == c) return true;
            for (int i = 0; i <= sqrt; i++)
            {
                hs.Add(i * i);
                if (hs.Contains(c - i * i)) return true;
            }
            return false;
        }
    }
    // @lc code=end

}