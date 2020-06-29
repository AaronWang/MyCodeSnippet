using System;
/*
 * @lc app=leetcode id=1403 lang=csharp
 *
 * [1403] Minimum Subsequence in Non-Increasing Order
 */
using System.Collections.Generic;
using System.Linq;

namespace MinSubsequence
{
    // @lc code=start
    public class Solution
    {
        public IList<int> MinSubsequence(int[] nums)
        {
            IList<int> list = new List<int>();
            if (nums.Length == 1) { list.Add(nums[0]); return list; }
            Array.Sort(nums);
            int sum = nums.Sum();
            int pickSum = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                list.Add(nums[i]);
                pickSum += nums[i];
                sum -= nums[i];
                if (pickSum > sum) return list;
            }
            return list;
        }
    }
    // @lc code=end

}