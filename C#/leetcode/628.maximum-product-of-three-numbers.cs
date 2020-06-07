using System;
/*
 * @lc app=leetcode id=628 lang=csharp
 *
 * [628] Maximum Product of Three Numbers
 */
namespace maximumProduct2
{
    // @lc code=start
    public class Solution
    {
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            return Math.Max(nums[0]*nums[1]*nums[nums.Length-1],nums[nums.Length-1]*nums[nums.Length-2]*nums[nums.Length-3]);
        }
    }
    // @lc code=end

}