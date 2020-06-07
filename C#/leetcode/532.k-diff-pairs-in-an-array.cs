using System;
using System.Collections.Generic;
/*
* @lc app=leetcode id=532 lang=csharp
*
* [532] K-diff Pairs in an Array
*/
namespace findPairs
{
    // @lc code=start
    public class Solution
    {
        public int FindPairs(int[] nums, int k)
        {
            int count = 0;
            int big, small;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                    {
                        big = Math.Max(nums[i], nums[j]);
                        small = Math.Min(nums[i], nums[j]);
                        if (!dict.ContainsKey(big))
                        {
                            dict.Add(big, small);
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
    // @lc code=end

}