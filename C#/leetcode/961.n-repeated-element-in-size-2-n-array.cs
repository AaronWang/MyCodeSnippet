/*
 * @lc app=leetcode id=961 lang=csharp
 *
 * [961] N-Repeated Element in Size 2N Array
 */
using System.Collections.Generic;

namespace RepeatedNTimes
{
    // @lc code=start
    public class Solution
    {
        public int RepeatedNTimes(int[] A)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (hs.Contains(A[i])) return A[i];
                else hs.Add(A[i]);
            }
            return 0;
        }
    }
    // @lc code=end

}