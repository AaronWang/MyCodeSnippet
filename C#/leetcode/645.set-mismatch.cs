using System.Linq;
/*
 * @lc app=leetcode id=645 lang=csharp
 *
 * [645] Set Mismatch
 */
using System.Collections.Generic;

namespace FindErrorNums
{
    // @lc code=start
    public class Solution
    {
        public int[] FindErrorNums(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            int errorNumber = -1;
            for (int i = 1; i <= nums.Length; i++)
            {
                if (hs.Contains(nums[i - 1])) errorNumber = nums[i - 1];
                else hs.Add(nums[i - 1]);
            }
            //find missing number;
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!hs.Contains(i)) return new int[] { errorNumber, i };
            }
            return null;
        }
    }
    // @lc code=end

}