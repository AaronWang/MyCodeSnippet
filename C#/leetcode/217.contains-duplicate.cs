/*
 * @lc app=leetcode id=217 lang=csharp
 *
 * [217] Contains Duplicate
 */
using System.Collections.Generic;

namespace containsDuplicate
{
    // @lc code=start
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> hs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hs.ContainsKey(nums[i]))
                    return true;
                hs.Add(nums[i], i);
            }
            return false;
        }
    }
    // @lc code=end

}