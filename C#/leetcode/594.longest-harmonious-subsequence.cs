using System.Collections.Specialized;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
/*
 * @lc app=leetcode id=594 lang=csharp
 *
 * [594] Longest Harmonious Subsequence
 */
namespace FindLHS
{
    // @lc code=start
    public class Solution
    {
        public int FindLHS(int[] nums)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int maxLength = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(nums[i]))
                    dictionary[nums[i]]++;
                else dictionary.Add(nums[i], 1);
            }
            foreach (var item in dictionary)
            {
                if (dictionary.ContainsKey(item.Key - 1))
                    maxLength = maxLength < dictionary[item.Key - 1] + item.Value ? dictionary[item.Key - 1] + item.Value : maxLength;
            }
            return maxLength;
        }
    }
    // @lc code=end

}