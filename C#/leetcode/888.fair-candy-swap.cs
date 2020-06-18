using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
/*
 * @lc app=leetcode id=888 lang=csharp
 *
 * [888] Fair Candy Swap
 */
namespace fairCandySwap
{
    // @lc code=start
    public class Solution
    {
        public int[] FairCandySwap(int[] A, int[] B)
        {
            int totalCandiesA = A.Sum();
            int totalCandiesB = B.Sum();
            int finnalValue = (totalCandiesB + totalCandiesA) / 2;
            Dictionary<int, int> find = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!find.ContainsKey(A[i]))
                    find.Add(A[i], i);
            }
            for (int i = 0; i < B.Length; i++)
            {
                if (find.ContainsKey(finnalValue - (totalCandiesB - B[i])))
                    // return new int[] { find[finnalValue - (totalCandiesB - B[i])], i };
                    return new int[] { finnalValue - (totalCandiesB - B[i]), B[i] };
            }
            return null;
        }
    }
    // @lc code=end
}