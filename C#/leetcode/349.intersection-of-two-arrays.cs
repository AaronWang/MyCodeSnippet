/*
 * @lc app=leetcode id=349 lang=csharp
 *
 * [349] Intersection of Two Arrays
 */
using System.Collections.Generic;

namespace Intersection3
{
    // @lc code=start
    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dictionary1 = new Dictionary<int, int>();
            Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (dictionary1.ContainsKey(nums1[i]))
                    dictionary1[nums1[i]]++;
                else dictionary1.Add(nums1[i], 1);
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (dictionary2.ContainsKey(nums2[i]))
                    dictionary2[nums2[i]]++;
                else dictionary2.Add(nums2[i], 1);
            }
            List<int> list = new List<int>();
            foreach (var item in dictionary1)
            {
                if (dictionary2.ContainsKey(item.Key))
                    list.Add(item.Key);
            }
            return list.ToArray();
        }
    }
    // @lc code=end

}