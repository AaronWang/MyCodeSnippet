using System;
using System.Linq;
/*
 * @lc app=leetcode id=1010 lang=csharp
 *
 * [1010] Pairs of Songs With Total Durations Divisible by 60
 */
namespace numpairsdivisibleBy60
{
    // @lc code=start
    public class Solution
    {
        public int NumPairsDivisibleBy60(int[] time)
        {
            int count = 0;
            int[] appear = new int[60];
            Array.Fill(appear, 0);
            int match = 0;
            for (int i = 0; i < time.Length; i++)
            {
                match = appear[(60 - time[i] % 60) % 60];
                if (match > 0)
                    count += match;
                appear[time[i] % 60]++;
            }
            return count;
        }
    }
    // @lc code=end

}