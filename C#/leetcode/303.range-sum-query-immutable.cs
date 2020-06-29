/*
 * @lc app=leetcode id=303 lang=csharp
 *
 * [303] Range Sum Query - Immutable
 */
using System.Collections.Generic;
using System.Linq;

namespace SumRange
{
    // @lc code=start
    public class NumArray
    {
        int[] nums;
        int sum;
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        public NumArray(int[] nums)
        {
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                dictionary.Add(i, sum);
            }
            dictionary.Add(-1, 0);
            dictionary.Add(nums.Length, sum);

            this.nums = nums;
        }

        public int SumRange(int i, int j)
        {
            return sum - dictionary[i - 1] - (sum - dictionary[j]);
        }
    }

    /**
     * Your NumArray object will be instantiated and called as such:
     * NumArray obj = new NumArray(nums);
     * int param_1 = obj.SumRange(i,j);
     */
    // @lc code=end

}