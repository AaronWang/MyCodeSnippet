using System;
/*
 * @lc app=leetcode id=1033 lang=csharp
 *
 * [1033] Moving Stones Until Consecutive
 */
namespace nummoverstones
{
    // @lc code=start
    public class Solution
    {
        // 3 \n 5 \n 1
        // 1 \n 7 \n 2
        public int[] NumMovesStones(int a, int b, int c)
        {
            int max = Math.Max(a, Math.Max(b, c));
            int min = Math.Min(a, Math.Min(b, c));
            int[] ans = new int[2];
            ans[1] = max - min - 2;
            if (ans[1] == 0) ans[0] = 0;
            else
            {
                if (Math.Abs(a - b) > 2 && Math.Abs(b - c) > 2 && Math.Abs(a - c) > 2)
                    ans[0] = 2;
                else ans[0] = 1;
            }
            return ans;

        }
    }
    // @lc code=end

}