using System.Linq;
using System;
/*
 * @lc app=leetcode id=561 lang=csharp
 *
 * [561] Array Partition I
 */
namespace arrayPairSum
{
    // @lc code=start
    public class Solution
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            return nums.Where((x, i) => i % 2 == 0).Aggregate((total, next) => total += next);
        }
    }
    // @lc code=end

}