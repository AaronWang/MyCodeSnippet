/*
 * @lc app=leetcode id=985 lang=csharp
 *
 * [985] Sum of Even Numbers After Queries
 */
using System;
using System.Linq;

namespace sumevenafterqueries
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     int[] vs = SumEvenAfterQueries(new int[] { 1, 2, 3, 4 }, new int[][] { new int[] { 1, 0 }, new int[] { -3, 1 }, new int[] { -4, 0 }, new int[] { 2, 3 } });
        // }
        public int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            var total = A.Aggregate(0, (total, value) =>
             total += ((value % 2 == 0) ? value : 0));
            int[] B = Enumerable.Repeat(total, A.Length).ToArray();
            int val, index;
            for (int i = 0; i < queries.Length; i++)
            {
                val = queries[i][0];
                index = queries[i][1];
                if (val % 2 == 0 && A[index] % 2 == 0)
                    B[i] += val;
                else if (Math.Abs(val % 2) == 1 && A[index] % 2 == 0)
                    B[i] -= A[index];
                else if (Math.Abs(val % 2) == 1 && Math.Abs(A[index] % 2) == 1)
                    B[i] += val + A[index];
                A[index] += val;
                if (i + 1 < queries.Length)
                    B[i + 1] = B[i];
            }
            return B;
        }
    }
    // @lc code=end

}