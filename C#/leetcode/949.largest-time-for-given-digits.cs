/*
 * @lc app=leetcode id=949 lang=csharp
 *
 * [949] Largest Time for Given Digits
 */
using System;

namespace LargestTimeFromDigits
{
    // @lc code=start
    public class Solution
    {
        public string LargestTimeFromDigits(int[] A)
        {
            Array.Sort(A);
            Array.Reverse(A);
            for (int h1 = 0; h1 < A.Length; h1++)
            {
                if (A[h1] > 2) continue;
                for (int h2 = 0; h2 < A.Length; h2++)
                {
                    if (h1 == h2) continue;
                    if (A[h1] * 10 + A[h2] > 23) continue;
                    for (int m1 = 0; m1 < A.Length; m1++)
                    {
                        if (m1 == h2 || m1 == h1) continue;
                        if (A[m1] > 5) continue;
                        for (int m2 = 0; m2 < A.Length; m2++)
                        {
                            if (m2 == m1 || m2 == h1 || m2 == h2) continue;
                            if (A[m1] * 10 + A[m2] > 59) continue;
                            return A[h1] + "" + A[h2] + ":" + A[m1] + A[m2];
                        }
                    }
                }
            }
            return "";
        }
    }
    // @lc code=end

}