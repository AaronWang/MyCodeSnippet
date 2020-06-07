using System.Collections.Generic;
using System.Linq;
/*
 * @lc app=leetcode id=268 lang=csharp
 *
 * [268] Missing Number
 */
namespace missingNumber
{
    // @lc code=start
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                // if(dict.ContainsKey(nums))
                dict.Add(nums[i], i);
            }
            for (int i = 0; i < nums.Length+1; i++)
                if (!dict.ContainsKey(i)) return i;
            return 0;
        }
    }
    // @lc code=end

}