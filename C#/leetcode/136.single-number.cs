using System.Linq;
using System;
using System.Collections.Generic;
/*
* @lc app=leetcode id=136 lang=csharp
*
* [136] Single Number
*/
namespace SingleNumber
{
    // @lc code=start
    public class Solution
    {
        //[2,1,4,1,2]
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(nums[i]))
                    dictionary[nums[i]] += 1;
                else
                    dictionary.Add(nums[i], 1);
            }
            return dictionary.Where(x => x.Value == 1).First().Key;
        }
    }
    // @lc code=end

}