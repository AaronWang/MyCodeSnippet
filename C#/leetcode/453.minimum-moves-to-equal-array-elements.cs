using System.Linq;
/*
 * @lc app=leetcode id=453 lang=csharp
 *
 * [453] Minimum Moves to Equal Array Elements
 */
namespace MinMoves
{
    // @lc code=start
    public class Solution
    {
        public int MinMoves(int[] nums)
        {
            //返回最小数和其它大数的差额
            int min = nums.Min();
            return nums.Aggregate(0, (total, next) =>
                 total += next - min
            );
        }
    }
    // @lc code=end

}