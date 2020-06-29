using System.Linq;
using System;
/*
 * @lc app=leetcode id=350 lang=csharp
 *
 * [350] Intersection of Two Arrays II
 */
using System.Collections.Generic;

namespace Intersect
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     Intersect(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });
        // }
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dictionaryNum1 = new Dictionary<int, int>();
            Dictionary<int, int> dictionaryNum2 = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (dictionaryNum1.ContainsKey(nums1[i]))
                    dictionaryNum1[nums1[i]]++;
                else dictionaryNum1.Add(nums1[i], 1);
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (dictionaryNum2.ContainsKey(nums2[i]))
                    dictionaryNum2[nums2[i]]++;
                else dictionaryNum2.Add(nums2[i], 1);
            }
            List<int> list = new List<int>();
            foreach (var item in dictionaryNum1)
            {
                if (dictionaryNum2.ContainsKey(item.Key))
                    list.AddRange(Enumerable.Repeat(item.Key, Math.Min(item.Value, dictionaryNum2[item.Key])));
            }
            return list.ToArray();
        }
    }
    // @lc code=end

}