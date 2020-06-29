using System;
/*
 * @lc app=leetcode id=1005 lang=csharp
 *
 * [1005] Maximize Sum Of Array After K Negations
 */
using System.Linq;

namespace LargestSumAfterKNegations
{
    // @lc code=start
    public class Solution
    {
        public int LargestSumAfterKNegations(int[] A, int K)
        {
            int sum = A.Sum();
            int smallest;
            for (int i = 0; i < K; i++)
            {
                smallest = A.Min();
                if (smallest < 0)
                    sum += 2 * smallest * (-1);
                else
                    sum -= smallest * 2;
                A[Array.IndexOf(A, smallest)] = smallest * (-1);
            }
            return sum;
        }
    }
    // @lc code=end

}