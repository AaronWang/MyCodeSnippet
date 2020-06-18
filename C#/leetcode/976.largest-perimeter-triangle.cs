using System;
/*
 * @lc app=leetcode id=976 lang=csharp
 *
 * [976] Largest Perimeter Triangle
 */
namespace LargestPerimeter
{
    // @lc code=start
    public class Solution
    {
        public int LargestPerimeter(int[] A)
        {
            int max = 0;
            Array.Sort(A);
            Array.Reverse(A);
            for (int i = 0; i < A.Length - 2; i++)
            {
                if (A[i] < A[i + 1] + A[i + 2])
                {
                    max = max < A[i] + A[i + 1] + A[i + 2] ? A[i] + A[i + 1] + A[i + 2] : max;
                }
                // for (int j = i + 1; j < A.Length - 1; j++)
                // {
                //     for (int z = j + 1; z < A.Length; z++)
                //     {
                // if (A[i] < A[j] + A[z])
                // {
                //     max = max < A[i] + A[j] + A[z] ? A[i] + A[j] + A[z] : max;
                // }
                //     }
                // }
            }
            return max;
        }
    }
    // @lc code=end

}