using System;
using System.Linq;
/*
 * @lc app=leetcode id=1029 lang=csharp
 *
 * [1029] Two City Scheduling
 */
namespace TwoCitySchedCost
{
    // @lc code=start
    public class Solution
    {
        public int TwoCitySchedCost(int[][] costs)
        {
            costs = costs.OrderBy(x => Math.Abs(x[0] - x[1])).ToArray();
            int A = costs.Length / 2;
            int B = A;
            int cost = 0;
            for (int i = costs.Length - 1; i >= 0; i--)
            {
                if (costs[i][0] > costs[i][1])
                {
                    if (B > 0)
                    {
                        B--;
                        cost += costs[i][1];
                    }
                    else
                    {
                        A--;
                        cost += costs[i][0];
                    }
                }
                else
                {
                    if (A > 0)
                    {
                        A--;
                        cost += costs[i][0];
                    }
                    else
                    {
                        B--;
                        cost += costs[i][1];
                    }
                }
            }
            return cost;
        }
    }
    // @lc code=end

}