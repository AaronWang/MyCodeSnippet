using System;
using System.Collections.Generic;
/*
 * @lc app=leetcode id=198 lang=csharp
 *
 * [198] House Robber
 */
namespace Rob
{
    // @lc code=start
    public class Solution
    {
        public int Rob(int[] nums)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            return RobRecursive(nums, 0, dictionary);
        }
        public int RobRecursive(int[] nums, int firstHouseToRob, Dictionary<int, int> dictionary)
        {
            if (dictionary.ContainsKey(firstHouseToRob)) return dictionary[firstHouseToRob];
            if (firstHouseToRob > nums.Length - 1) return 0;
            if (firstHouseToRob == nums.Length - 1) return nums[firstHouseToRob];
            if (firstHouseToRob == nums.Length - 2) return Math.Max(nums[firstHouseToRob], nums[firstHouseToRob + 1]);
            int max = Math.Max(nums[firstHouseToRob] + RobRecursive(nums, firstHouseToRob + 2, dictionary), nums[firstHouseToRob + 1] + RobRecursive(nums, firstHouseToRob + 3, dictionary));
            dictionary.Add(firstHouseToRob, max);
            return max;
        }
    }
    // @lc code=end

}