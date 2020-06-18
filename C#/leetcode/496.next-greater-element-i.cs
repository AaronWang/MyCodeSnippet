using System;
using System.Linq;
/*
 * @lc app=leetcode id=496 lang=csharp
 *
 * [496] Next Greater Element I
 */
namespace NextGreaterElement
{
    // @lc code=start
    public class Solution
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int index;
            int[] result = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums2[j] == nums1[i])
                    {
                        int s = j + 1;
                        for (s = j + 1; s < nums2.Length; s++)
                        {
                            if (nums2[j] < nums2[s]) { result[i] = nums2[s]; break; }
                        }
                        if (s == nums2.Length) result[i] = -1;
                    }
                }
            }
            return result;
        }
    }
    // @lc code=end

}