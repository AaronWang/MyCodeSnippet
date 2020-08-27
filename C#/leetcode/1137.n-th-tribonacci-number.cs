using System.Collections.Generic;
/*
 * @lc app=leetcode id=1137 lang=csharp
 *
 * [1137] N-th Tribonacci Number
 */
namespace Tribonacci
{
    // @lc code=start
    public class Solution
    {
        Dictionary<int, int> dp = new Dictionary<int, int>();
        public int Tribonacci(int n)
        {
            if (dp.ContainsKey(n)) return dp[n];
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;
            dp.Add(n, Tribonacci(n - 1) + Tribonacci(n - 2) + Tribonacci(n - 3));
            return dp[n];
        }
    }
    // @lc code=end

}