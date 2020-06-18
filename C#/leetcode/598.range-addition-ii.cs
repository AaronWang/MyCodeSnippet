using System.Linq;
using System.IO.Pipes;
/*
 * @lc app=leetcode id=598 lang=csharp
 *
 * [598] Range Addition II
 */
namespace MaxCount
{
    // @lc code=start
    public class Solution
    {
        public int MaxCount(int m, int n, int[][] ops)
        {
            if (ops.Length == 0) return m * n;
            return ops.Aggregate((min, next) =>
            {
                if (min[0] > next[0]) min[0] = next[0];
                if (min[1] > next[1]) min[1] = next[1];
                return min;
            }).Aggregate((div, next) => div *= next);
        }
    }
    // @lc code=end

}