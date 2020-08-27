using System;
/*
 * @lc app=leetcode id=292 lang=csharp
 *
 * [292] Nim Game
 */
using System.Collections.Generic;

namespace CanWinNim
{
    // @lc code=start
    public class Solution
    {
        //this method will be over flow
        // Dictionary<int, bool> dp = new Dictionary<int, bool>();
        public bool CanWinNim(int n)
        {
            return n % 4 != 0;
            // if (dp.ContainsKey(n)) return dp[n];
            // if (n == 1) return true;
            // if (n == 2) return true;
            // if (n == 3) return true;

            // dp.Add(n, !CanWinNim(n - 1) || !CanWinNim(n - 2) || !CanWinNim(n - 3));
            // return dp[n];
        }
    }
    // @lc code=end

}