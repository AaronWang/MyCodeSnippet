/*
 * @lc app=leetcode id=448 lang=csharp
 *
 * [448] Find All Numbers Disappeared in an Array
 */
using System.Collections.Generic;

namespace finddisappearedNumbers11
{
    // @lc code=start
    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            IList<int> list = new List<int>();
            for (int i = 0; i < nums.LongLength; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
            }
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!dict.ContainsKey(i))
                    list.Add(i);
            }
            return list;
        }
    }
    // @lc code=end

}