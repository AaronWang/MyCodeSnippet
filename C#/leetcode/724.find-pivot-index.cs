/*
 * @lc app=leetcode id=724 lang=csharp
 *
 * [724] Find Pivot Index
 */
using System.Linq;

namespace PivotIndex
{
    // @lc code=start
    public class Solution
    {
        public int PivotIndex(int[] nums)
        {
            // [-1,-1,-1,0,1,1]
            // [-1,-1,0,1,1,0]
            // [-1,-1,1,1,0,0]
            if (nums.Length < 3) return -1;
            int left, right;
            right = nums.Sum();
            if (right - nums.First() == 0) return 0;//first

            left = 0;
            right -= nums[0];
            for (int i = 1; i < nums.Length - 1; i++)
            {
                left += nums[i - 1];
                right -= nums[i];

                if (left == right)
                    return i;
            }
            if (nums.Sum() - nums.Last() == 0) return nums.Length - 1;//last
            return -1;
        }
    }
    // @lc code=end

}