using System.Linq;
using System.Collections.Generic;
/*
 * @lc app=leetcode id=169 lang=csharp
 *
 * [169] Majority Element
 */
namespace MojorityElement
{
    // @lc code=start
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                    dict[nums[i]]++;
                else
                    dict.Add(nums[i], 1);
            }
            int half = nums.Length / 2;
            int count = dict.Values.Max();
            foreach (int i in dict.Keys)
            {
                if (dict[i] == count)
                    return i;
            }
            return 0;
        }
    }
    // @lc code=end

}