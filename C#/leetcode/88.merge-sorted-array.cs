using System;
/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 */
namespace Merge
{
    // @lc code=start
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m; i < nums1.Length; i++)
            { nums1[i] = nums2[i - m]; }
            Array.Sort(nums1);
        }
    }
    // @lc code=end

}