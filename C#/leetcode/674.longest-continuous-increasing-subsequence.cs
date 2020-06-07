/*
 * @lc app=leetcode id=674 lang=csharp
 *
 * [674] Longest Continuous Increasing Subsequence
 */
namespace FindLengthOfLCIS
{
    // @lc code=start
    public class Solution
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            int longest = 1;
            int longestTmp = 1;
            if (nums.Length == 0) return 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    longestTmp++;
                    if (longestTmp > longest)
                        longest = longestTmp;
                }
                else longestTmp = 1;
            }
            return longest;
        }
    }
    // @lc code=end

}