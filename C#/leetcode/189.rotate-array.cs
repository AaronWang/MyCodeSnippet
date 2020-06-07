using System.Linq;
using System.Collections.Generic;
using System;
/*
 * @lc app=leetcode id=189 lang=csharp
 *
 * [189] Rotate Array
 */
namespace Rotate
{
    // @lc code=start
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            k=k % nums.Length;
            // if (nums.Length == 1) return;
            
            int[] result = new int[nums.Length];
            Array.Copy(nums, nums.Length - k, result, 0, k);
            Array.Copy(nums, 0, result, k, nums.Length - k);
            Array.Copy(result, 0, nums, 0, nums.Length);
        }
    }
    // @lc code=end

}