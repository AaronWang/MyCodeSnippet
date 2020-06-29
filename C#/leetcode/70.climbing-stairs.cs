using System;
/*
 * @lc app=leetcode id=70 lang=csharp
 *
 * [70] Climbing Stairs
 */
using System.Collections.Generic;

namespace ClimbStairs
{
    // @lc code=start
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            return ClimbStairsRecursive(n, dictionary);
        }
        public int ClimbStairsRecursive(int n, Dictionary<int, int> dictionary)
        {
            if (dictionary.ContainsKey(n)) return dictionary[n];
            if (n == 1) return 1;
            if (n == 2) return 2;
            int totalWays = ClimbStairsRecursive(n - 1, dictionary) + ClimbStairsRecursive(n - 2, dictionary);
            dictionary.Add(n, totalWays);
            return totalWays;
        }
    }
    // @lc code=end

}