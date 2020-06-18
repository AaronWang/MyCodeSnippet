/*
 * @lc app=leetcode id=908 lang=csharp
 *
 * [908] Smallest Range I
 */
using System.Linq;

namespace SmallestRangeI
{
    // @lc code=start
    public class Solution
    {
        public int SmallestRangeI(int[] A, int K)
        {
            int result = A.Max() - A.Min() - K * 2;
            return result < 0 ? 0 : result;
        }
    }
    // @lc code=end

}